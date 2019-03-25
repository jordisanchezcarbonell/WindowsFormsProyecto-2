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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialContextMenuStrip1.Text == "admin" || textboxcontra.Text == "1")
            {
                
                FormMenuPrincipal p = new FormMenuPrincipal();
                p.ShowDialog();
            }
            else
            {
                //MaterialM.Show("Your cool message here", "The awesome message title");
                MaterialMessageBox.ShowError("Error el usuario");


            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
    }
}
