using BlowFishCS;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class Entitats : Estilo
    {
        //Aquest objecte és el que utilitzaré per encriptar amb BlowFish:
        BlowFish blowFish = new BlowFish("04B915BA43FEB5B6");
        
        //Creo una constant per guardar la llargada mínima de la contrasenya:
        const int LLARGADA_MINIMA_CONTRASENYA = 8;

        public Entitats()
        {
            InitializeComponent();
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Entitats_Load(object sender, EventArgs e)
        {
            carregarDadesGrid();
        }


        public void carregarDadesGrid()
        {
            //Creo la list de ciutats, que ompliré passant-la per referència:
            List<Entidad> llistaEntitats = new List<Entidad>();

            //Crido al mètode per obtenir totes les entitats i ho adjudico al bindingSource corresponenet:
            string missatgeRetornat = BD.EntitatsORM.SelectAllEntitats(ref llistaEntitats);
            
            
            if (missatgeRetornat.Equals(""))
            {
                bindingSourceEntitats.DataSource = llistaEntitats;
            } else
            {
                MessageBox.Show(missatgeRetornat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void materialRaisedButtonAfegir_Click(object sender, EventArgs e)
        {
            //Variable on guardaré el número de temporada si he pogut convertir correctament de string a int:
            int numTemporada;
            
            //Comprovo que les contrasenyes siguin iguals, que tinguin com a mínim 8 caràcters
            if (materialSingleLineTextFieldContrasenya.TextLength == materialSingleLineTextFieldRepetirContrasenya.TextLength
                 && materialSingleLineTextFieldContrasenya.TextLength >= LLARGADA_MINIMA_CONTRASENYA)
            {

                //Un cop he comprovat la contrasenya, comprovo que el que hi ha al camp temporada sigui un número (int):
                if (int.TryParse(materialSingleLineTextFieldTemporada.Text, out numTemporada))
                {

                    //NumeroNif numeroNif = new NumeroNif(materialSingleLineTextFieldNif.Text);numeroNif.EsCorrecto
                    if (true)
                    {
                        //Encripto la contrasenya:
                        string contrasenyaEncriptada = encriptarBlowFish(materialSingleLineTextFieldContrasenya.Text);
                        
                        //Faig un insert a la base de dades passant-li com a paràmetres el contingut dels camps del formulari:
                        string missatge = BD.EntitatsORM.InsertEntitat(materialSingleLineTextFieldNom.Text, numTemporada,
                            materialSingleLineTextFieldAdreca.Text, materialSingleLineTextFieldNif.Text, materialSingleLineTextFieldCorreo.Text,
                            contrasenyaEncriptada);

                        if (missatge.Equals(""))
                        {
                            carregarDadesGrid();
                        }
                        else
                        {
                            MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El format del NIF és erroni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El camp temporada només admet números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    materialSingleLineTextFieldTemporada.Clear();
                }
            } 
            else
            {
                MessageBox.Show("Les contrasenyes han de coincidir i han de tenir 8 caràcters de longitud", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Netejo els camps de les contrasenyes:
                materialSingleLineTextFieldContrasenya.Clear();
                materialSingleLineTextFieldRepetirContrasenya.Clear();
            }
        }


        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            //Crido al mètode per fer un update, i gestiono la frase que em torna el mètode per fer l'update:
            Entidad entitatRecuperada = (Entidad)dataGridViewDadesEntitats.CurrentRow.DataBoundItem;
            entitatRecuperada.nombre = materialSingleLineTextFieldNom.Text;
            entitatRecuperada.temporada = int.Parse(materialSingleLineTextFieldTemporada.Text);
            entitatRecuperada.direccion = materialSingleLineTextFieldAdreca.Text;
            entitatRecuperada.nif = materialSingleLineTextFieldNif.Text;
            entitatRecuperada.correo = materialSingleLineTextFieldCorreo.Text;
            //entitatRecuperada.contrasenya = materialSingleLineTextFieldContrasenya.Text;

            //Encripto la contrasenya modificada:
            string contrasenyaEncriptada = encriptarBlowFish(materialSingleLineTextFieldContrasenya.Text);

            string missatge = BD.EntitatsORM.UpdateEntitat(entitatRecuperada.id, entitatRecuperada.nombre,
                entitatRecuperada.temporada, entitatRecuperada.direccion, entitatRecuperada.nif, 
                entitatRecuperada.correo, contrasenyaEncriptada);

            if (missatge.Equals(""))
            {
                carregarDadesGrid();
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialRaisedButtonEsborrar_Click(object sender, EventArgs e)
        {
            //Recupero l'objecte clicat i l'esborro de la base de dades:
            Entidad entitatEsborrar = (Entidad)dataGridViewDadesEntitats.CurrentRow.DataBoundItem;
            string missatge = BD.EntitatsORM.deleteEntitat(entitatEsborrar.id);

            //En funció del missatge retornat pel mètode delete, recarrego la grid o mostro un missatge
            if (missatge.Equals(""))
            {
                carregarDadesGrid();
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDadesEntitats_SelectionChanged(object sender, EventArgs e)
        {
            //Creo una variable que tindrà 8 caràcters, que serà la que mostraré sempre al camp contrasenya. Així
            //aconsegueixo que quan es cliqui un registre de la grid, els camps contrasenya s'omplin amb el mateix número
            //de puntets, i no es pugui saber la llargada de la contrasenya.
            string contrasenyaMostrar = "12345678";
            
            //Recupero l'objecte clicat i poso les dades als camps
            Entidad entitatClicada = (Entidad)dataGridViewDadesEntitats.CurrentRow.DataBoundItem;
            materialSingleLineTextFieldNom.Text = entitatClicada.nombre;
            materialSingleLineTextFieldTemporada.Text = entitatClicada.temporada.ToString();
            materialSingleLineTextFieldAdreca.Text = entitatClicada.direccion;
            materialSingleLineTextFieldNif.Text = entitatClicada.nif;
            materialSingleLineTextFieldCorreo.Text = entitatClicada.correo;
            materialSingleLineTextFieldContrasenya.Text = contrasenyaMostrar;
            materialSingleLineTextFieldRepetirContrasenya.Text = contrasenyaMostrar;
        }

        private void materialRaisedButtonNetejarCamps_Click(object sender, EventArgs e)
        {
            netejarCampsDesseleccionarGrid();
        }

        private void netejarCampsDesseleccionarGrid()
        {
            //Netejo els camps i desselecciono la línia seleccionada (ha d'estar en aquest ordre, sinó no funciona)
            dataGridViewDadesEntitats.ClearSelection();
            dataGridViewDadesEntitats.CurrentCell = null;

            materialSingleLineTextFieldNom.Clear();
            materialSingleLineTextFieldTemporada.Clear();
            materialSingleLineTextFieldAdreca.Clear();
            materialSingleLineTextFieldNif.Clear();
            materialSingleLineTextFieldCorreo.Clear();
            materialSingleLineTextFieldContrasenya.Clear();
            materialSingleLineTextFieldRepetirContrasenya.Clear();
        }

        private void dataGridViewDadesEntitats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Aquest mètode s'activa un cop s'ha connectat amb la base de dades i s'ha omplert la grid
            netejarCampsDesseleccionarGrid();
        }

        private void materialRaisedButtonTelefons_Click(object sender, EventArgs e)
        {
            Telefons telefons = new Telefons();
            telefons.ShowDialog();
        }


        //Mètodes per encriptar i desencriptar:
        public string encriptarBlowFish(string textEncriptar)
        {
            string textEncriptat = blowFish.Encrypt_CBC(textEncriptar);

            return textEncriptat;
        }


        public string desencriptarBlowFish(string textDesencriptar)
        {
            string textDesencriptat = blowFish.Encrypt_CBC(textDesencriptar);

            return textDesencriptat;
        }

    }
}
