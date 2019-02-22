using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApplication2
{
    public partial class Entitats : MaterialForm
    {
        public Entitats()
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

        private void Entitats_Load(object sender, EventArgs e)
        {

        }
    }
}
