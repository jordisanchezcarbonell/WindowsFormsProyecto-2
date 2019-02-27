
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
using System.Drawing;
using BespokeFusion;




namespace WindowsFormsApplication2
{
    public partial class Activitats : MaterialForm
    {
        public Activitats()
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

        private void Activitats_Load(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
