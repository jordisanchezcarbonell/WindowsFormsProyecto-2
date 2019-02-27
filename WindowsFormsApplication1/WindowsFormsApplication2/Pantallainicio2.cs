using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Pantallainicio2 : Pantaltest
    {
        public Pantallainicio2()
        {
            InitializeComponent();
        }

        private void Pantallainicio2_Load(object sender, EventArgs e)
        {
           

            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHor.Text = DateTime.Now.ToString("HH:mm:ssss");

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
        }
        private void AbrirFormEnPanel(object eeeeee)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = eeeeee as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            Entitats fm = new Entitats();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfilModificar fm = new PerfilModificar();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);

        }

        private void Pantallainicio2_Activated(object sender, EventArgs e)
        {
        }
    }
}
