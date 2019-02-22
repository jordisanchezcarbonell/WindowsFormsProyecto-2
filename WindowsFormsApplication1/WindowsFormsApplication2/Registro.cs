using System;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;



namespace WindowsFormsApplication2
{
    public partial class Registro : MaterialForm
    {
        bool estado = false;
        public Registro()
        {
            Bitmap bm = (Bitmap)Bitmap.FromFile(@"D:\Imageneshoteles\PROYECYO\logo.png");

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.logo_omet_amb_ajuntament_nou_529;

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
