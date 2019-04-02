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
    public partial class Entitats : Estilo
    {
      

        public Entitats()
        {
            InitializeComponent();
           
            String mensaje = "";
            bindingSource2.DataSource = BD.Equipos.test(ref mensaje);

            //bindingSource2.DataSource = BD.Entidades.test(ref mensaje);
            //telefonosDataGridViewTextBoxColumn1.DataSource = BD.Entidades.test(ref mensaje);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entitats_Load(object sender, EventArgs e)
        {
         
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
