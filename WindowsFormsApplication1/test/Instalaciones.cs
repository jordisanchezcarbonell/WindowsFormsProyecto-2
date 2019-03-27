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
    public partial class Instalaciones : Estilo
    {
        public Instalaciones()
        {
            InitializeComponent();
        }

        private void Instalaciones_Load(object sender, EventArgs e)
        {


        }

        private void Instalaciones_Load_1(object sender, EventArgs e)
        {
          //  bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            bindingSource1.DataSource = BD.Instalacions.SelectAllInstalaciones();

        }

        private void materialSingleLineTextFieldTitulo_TextChanged(object sender, EventArgs e)
        {
            bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectInstalacionesByNombre(materialSingleLineTextFieldTitulo.Text);
        }

        private void materialSingleLineTextFieldTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
