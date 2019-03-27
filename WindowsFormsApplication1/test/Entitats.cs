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
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Entitats_Load(object sender, EventArgs e)
        {
            carregarDadesGrid();
        }


        public void carregarDadesGrid()
        {
            //Creo la list de ciutats, que ompliré passant-la per referència:
            List<Entidad> llistaEntitats = new List<Entidad>();

            //Crido al mètode per obtenir totes les entitats i ho adjudico al bindingSource corresponenet:
            string missatgeRetornat = BD.EntitatsORM.SelectAllEntitats(ref llistaEntitats);
            
            
            if (!missatgeRetornat.Equals(""))
            {
                bindingSourceEntitats.DataSource = llistaEntitats;
            } else
            {
                MessageBox.Show(missatgeRetornat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
