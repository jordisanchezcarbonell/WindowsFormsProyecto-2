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
    public partial class Activitats : Estilo
    {
        String mensaje = "";
        public Activitats()
        {
            InitializeComponent();
        }

        private void cargardatos()
        {
            bindingSourceASolitades.DataSource = BD.ActivitatsORM.SelectAllActividaddemanadas(ref mensaje);
            bindingSourceAssignades.DataSource = BD.ActivitatsORM.SelectAllActconcedida(ref mensaje);
            bindingSourceEspais.DataSource = BD.ActivitatsORM.SelectAllEspacio(ref mensaje);
            bindingSourceHorari.DataSource = BD.ActivitatsORM.SelectAllHorario_Act_Dem(ref mensaje);
            bindingSourceDias.DataSource = BD.ActivitatsORM.SelectAllDiasSemana(ref mensaje);
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Activitats_Load(object sender, EventArgs e)
        {
            cargardatos();

        }

        private void Activitats_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Act_demandadas _act = (Act_demandadas)dataGridView1.CurrentRow.DataBoundItem;

            Horario test = new Horario(_act);
            test.Show();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Act_demandadas _act = (Act_demandadas)dataGridView1.CurrentRow.DataBoundItem;

            Horario test = new Horario(_act);
            test.Show();
        }
    }
}
