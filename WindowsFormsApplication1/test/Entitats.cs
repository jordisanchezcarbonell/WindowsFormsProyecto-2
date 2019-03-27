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
            //Comprovo que les contrasenyes siguin iguals, i que tinguin 8 caràcters
            if (materialSingleLineTextFieldContrasenya.TextLength == materialSingleLineTextFieldRepetirContrasenya.TextLength
                 && materialSingleLineTextFieldContrasenya.TextLength == 8)
            {

                //Faig un insert a la base de dades passant-li com a paràmetres el contingut dels camps del formulari:
                string missatge = BD.EntitatsORM.InsertEntitat(materialSingleLineTextFieldNom.Text, materialSingleLineTextFieldTemporada.Text,
                    materialSingleLineTextFieldAdreca.Text, materialSingleLineTextFieldNif.Text, materialSingleLineTextFieldCorreo.Text,
                    materialSingleLineTextFieldContrasenya.Text);

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
            entitatRecuperada.contrasenya = materialSingleLineTextFieldContrasenya.Text;

            string missatge = BD.EntitatsORM.UpdateEntitat(entitatRecuperada.id, entitatRecuperada.nombre,
                entitatRecuperada.temporada, entitatRecuperada.direccion, entitatRecuperada.nif, 
                entitatRecuperada.correo, entitatRecuperada.contrasenya);

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
            //Recupero l'objecte clicat i poso les dades als camps
            Entidad entitatClicada = (Entidad)dataGridViewDadesEntitats.CurrentRow.DataBoundItem;
            materialSingleLineTextFieldNom.Text = entitatClicada.nombre;
            materialSingleLineTextFieldTemporada.Text = entitatClicada.temporada.ToString();
            materialSingleLineTextFieldAdreca.Text = entitatClicada.direccion;
            materialSingleLineTextFieldNif.Text = entitatClicada.nif;
            materialSingleLineTextFieldCorreo.Text = entitatClicada.correo;
            materialSingleLineTextFieldContrasenya.Text = entitatClicada.contrasenya;
        }

        private void materialRaisedButtonNetejarCamps_Click(object sender, EventArgs e)
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
        }
    }
}
