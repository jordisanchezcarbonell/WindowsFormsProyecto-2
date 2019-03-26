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

        }

        public void carregarDadesGrid()
        {
            //Creo la list de ciutats, que ompliré passant-la per referència:
            List<Entidad> llistaEntitats = new List<Entidad>();

            //Crido al mètode per obtenir totes les entitats i ho adjudico al bindingSource corresponenet:
            string missatgeRetornat = BD.EntitatsORM.SelectAllEntitats(ref llistaEntitats);
                //Aquí ha d'anar el binding source
            


            //Creo la llista de ciutats que passaré per referència:
            List<ciudades> llistaCiutats = new List<ciudades>();

            //Demano les dades a la classe estàtica i les guardo a la varigable que passo per referència:
            string missatgeRetornat = BD.CiudadesORM.SelectAllCiudades(ref llistaCiutats);
            ciudadesBindingSource.DataSource = llistaCiutats;

            if (!missatgeRetornat.Equals(""))
            {
                MessageBox.Show(missatgeRetornat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Crido al mètode que en funció del valor que estigui seleccionat a la combo, mostrarà els hotels d'aquella ciutat
                recuperarHotelsPerCiutatSeleccionada();
            }
        }


    }
}
