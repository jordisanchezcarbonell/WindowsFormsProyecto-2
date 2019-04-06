using BespokeFusion;
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
    public partial class Login : MaterialForm
    {
        private String mensaje = "";
        public Login()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue400,
                TextShade.WHITE
            );
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            limpiarTextRegistro();
            panel1.Visible = true;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          
            if (BD.LoginOrm.selectAdmins(textboxnom.Text,textboxcontra.Text) != null)
            {                
                FormMenuPrincipal p = new FormMenuPrincipal();
                p.Show();
                //this.Close();

            }else
            {
                //MaterialM.Show("Your cool message here", "The awesome message title");
                MaterialMessageBox.Show("Error el usuario", "ERROR");
            }
        }       

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if(textBoxRegistroNombreUsuario.Text != "")
            {
                if(textBoxRegistroContraseña.Text.Equals(textBoxRegistroConfirmarContraseña.Text))
                {
                    if(textBoxRegistroCorreo.Text.Equals(textBoxRegistroConfirmarCorreo.Text))
                    {
                        if(checkBoxRegistroCondicionesLegales.Checked)
                        {
                            mensaje = BD.LoginOrm.InsertarAdmin(textBoxRegistroNombreUsuario.Text,
                                                                textBoxRegistroCorreo.Text,
                                                                textBoxRegistroContraseña.Text);
                            MessageBox.Show("¡Te has dado de alta correctamente!", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cerrarFormRegistro();
                        }
                        else
                        {
                            mostrarVisualErrorMessageBox("¡Acepta las condiciones legales!");
                        }                        
                    }
                    else
                    {
                        mostrarVisualErrorMessageBox("¡El correo electrónico no coincide");
                        textBoxRegistroCorreo.Focus();
                    }
                }
                else
                {
                    mostrarVisualErrorMessageBox("¡Las contraseñas no coinciden!");
                    textBoxRegistroContraseña.Focus();
                }                
            }
            else
            {
                mostrarVisualErrorMessageBox("¡Escribe un nombre de usuario!");
                textBoxRegistroNombreUsuario.Focus();
            }            
        }

        private void mostrarVisualErrorMessageBox(String mensaje)
        {
            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void limpiarTextRegistro()
        {
            textBoxRegistroConfirmarContraseña.Clear();
            textBoxRegistroConfirmarCorreo.Clear();
            textBoxRegistroContraseña.Clear();
            textBoxRegistroCorreo.Clear();
            textBoxRegistroNombreUsuario.Clear();
            checkBoxRegistroCondicionesLegales.Checked = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cerrarFormRegistro();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormRegistro();
        }

        private void cerrarFormRegistro()
        {
            panel1.Visible = false;
        }
    }
}
