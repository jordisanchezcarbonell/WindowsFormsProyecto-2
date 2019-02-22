using System;
using MaterialSkin.Controls;


namespace WindowsFormsApplication2
{
    public partial class pantallaInicio : MaterialForm
    {
        public pantallaInicio()
        {
            InitializeComponent();
        }

        private int imagenumber = 1;
        /*private void loadfotos()
        {
            if(imagenumber == 10)
            {
                imagenumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"D:\Imageneshoteles\PROYECYO\WindowsFormCepLaucnher-master\WindowsFormsApplication1\WindowsFormsApplication2\obj\Debug\Imagenes{0}.png", imagenumber);
            imagenumber++;
        }*/
        private void pantallaInicio_Load(object sender, EventArgs e)
        {

        }

     /*   private void timer1_Tick(object sender, EventArgs e)
        {
            loadfotos();
        }
        */
    }
}
