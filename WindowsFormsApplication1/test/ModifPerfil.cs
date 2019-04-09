using BlowFishCS;
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
    public partial class ModifPerfil : Estilo
    {
        BlowFish blowFish = new BlowFish("04B915BA43FEB5B6");
        String mensaje = "";
        const int LLARGADA_MINIMA_CONTRASENYA = 8;

        public ModifPerfil()
        {
            InitializeComponent();
        }

        private void cargardatos()
        {
            bindingSourceAdmin.DataSource = BD.LoginOrm.SelectAllAdmin(ref mensaje);
            dataGridViewAdmin.AutoResizeColumns();
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        private void ModifPerfil_Load(object sender, EventArgs e)
        {

        }

        private void ModifPerfil_Load_1(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void Limpiarcampos()
        {
            dataGridViewAdmin.ClearSelection();
            dataGridViewAdmin.CurrentCell = null;
            materialSingleLineTextFieldUsuari.Clear();
            materialSingleLineTextFieldCorreu.Clear();
            materialSingleLineTextFieldContrasenya.Clear();
            materialSingleLineTextFieldRepetirContrasenya.Clear();

        }

        private void materialRaisedButtonvaciar_Click(object sender, EventArgs e)
        {
            Limpiarcampos();
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string contrasenyaMostrar = "12345678";

            //Recupero l'objecte clicat i poso les dades als camps
            Admin adminclick = (Admin)dataGridViewAdmin.CurrentRow.DataBoundItem;
            materialSingleLineTextFieldUsuari.Text = adminclick.nombre;
            materialSingleLineTextFieldCorreu.Text = adminclick.correo;
            materialSingleLineTextFieldContrasenya.Text = blowFish.Decrypt_CBC(adminclick.contrasenya);
            materialSingleLineTextFieldRepetirContrasenya.Text = blowFish.Decrypt_CBC(adminclick.contrasenya);
        }

        private void materialRaisedButtonAfegir_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextFieldUsuari.Text != "" && materialSingleLineTextFieldCorreu.Text != "")
            {
                if (materialSingleLineTextFieldContrasenya.TextLength == materialSingleLineTextFieldRepetirContrasenya.TextLength
                     && materialSingleLineTextFieldContrasenya.TextLength >= LLARGADA_MINIMA_CONTRASENYA)
                {

                    mensaje = BD.LoginOrm.InsertarAdmin(materialSingleLineTextFieldUsuari.Text, materialSingleLineTextFieldCorreu.Text, blowFish.Encrypt_CBC(materialSingleLineTextFieldContrasenya.Text));

                    if (mensaje.Equals(""))
                    {
                        MessageBox.Show("S'ha donat de alta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargardatos();

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Les contrasenyes han de coincidir i han de tenir 8 caràcters de longitud",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Introduexi el usuari i el correu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ModifPerfil_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void materialRaisedButtonEsborrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                Admin Admindel = (Admin)dataGridViewAdmin.CurrentRow.DataBoundItem;
                mensaje = BD.LoginOrm.Deleteadmin(Admindel.id);
        
                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("S'ha eliminat correctament", "BORRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargardatos();


                }

            }
        }

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            mensaje = BD.LoginOrm.UpgradeAdmin((int)dataGridViewAdmin.CurrentRow.Cells[0].Value, materialSingleLineTextFieldUsuari.Text, materialSingleLineTextFieldCorreu.Text, blowFish.Encrypt_CBC(materialSingleLineTextFieldContrasenya.Text));
            if (mensaje.Equals(""))
            {
                MessageBox.Show("S'ha actualitzat", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargardatos();

            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

