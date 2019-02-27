using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BespokeFusion;

namespace WindowsFormsApplication2
{
    public partial class Login : MaterialForm
    {
        bool estado = false;
        public Login()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue400,
                TextShade.WHITE
            );
            this.Text = "Login";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(materialSingleLineTextField1.Text == "admin" || textboxcontra.Text == "1")
            {
                estado = true;
                Registro p = new Registro();
                p.ShowDialog();
            }
            else
            {
                //MaterialM.Show("Your cool message here", "The awesome message title");
                MaterialMessageBox.ShowError("Error el usuario");


            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            this.Text = "assdasddsadasdasd";

        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
