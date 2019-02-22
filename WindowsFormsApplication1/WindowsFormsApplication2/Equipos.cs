using System;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApplication2
{
    public partial class Equipos : MaterialForm
    {
        public Equipos()
        {
            InitializeComponent();
            
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

        private void Equipos_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }
    }
}
