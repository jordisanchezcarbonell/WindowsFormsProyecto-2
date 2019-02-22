using System;
using MaterialSkin;
using MaterialSkin.Controls;


namespace WindowsFormsApplication2
{
    public partial class Instalaciones_y_Espacios : MaterialForm
    {
        public Instalaciones_y_Espacios()
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

        private void Instalaciones_y_Espacios_Load(object sender, EventArgs e)
        {

        }
    }
}
