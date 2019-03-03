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

namespace WindowsFormsApplication2
{
    public partial class PantallaInicio : MaterialForm
    {

        private int imageNumero = 1;
        private void CargarImagenes()
        {
            if (imageNumero==4)
            {
                imageNumero = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"imagenes\{0}.JPG", imageNumero);
            imageNumero++;
        }
        public PantallaInicio()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900,
                Primary.Green500, Accent.LightBlue400,
                TextShade.WHITE
            );

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            
        }
        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToString("HH:mm:ssss");
            /* // materialLabel1.Text = DateTime.Now.ToString("hh:mm:ss");
              label1.Text = DateTime.Now.ToString("h:mm:ss"); 
              label1.ForeColor = Color.DodgerBlue;
              label2.Text = DateTime.Now.ToShortDateString();
             // materialLabel1.ForeColor= Color.DodgerBlue;
             // materialLabel2.Text = DateTime.Now.ToShortDateString();*/

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
