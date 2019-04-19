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
    public partial class Horario : Estilo
    {
        private void SetBorderAndGridlineStyles()
        {
            this.dataGridView1.GridColor = Color.Green;
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle =
                DataGridViewCellBorderStyle.None;
            this.dataGridView1.RowHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.GridColor = Color.Green;
            this.dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle =
                DataGridViewCellBorderStyle.None;
            this.dataGridView2.RowHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        String mensaje = "";
        int outValue = 0;
        private Act_demandadas _act;

        public Horario(Act_demandadas _act)
        {
            InitializeComponent();
            this._act = _act;
        }
        public Horario()
        {
            InitializeComponent();

        }
        private void cargardatos()
        {
            diasSemanaBindingSource.DataSource = BD.ActivitatsORM.SelectAllHorario_Act_Dem(ref mensaje);
            bindingSourceEsport.DataSource = BD.Equipos.SELECTEQUIPO(ref mensaje);
            bindingSourceEspai.DataSource = BD.Espais.SelectAllEspais(ref mensaje);
            bindingSourceActividadconc.DataSource = BD.ActivitatsORM.SelectAllActconcedida(ref mensaje);
            bindingSourceHorariocon.DataSource = BD.ActivitatsORM.SelectAllHorario_Act_Con(ref mensaje);
            bindingSourceHorariotest.DataSource = BD.ActivitatsORM.SelectAllActdem(ref mensaje);

            bindingSourceDiadelasemana.DataSource = BD.Diasemana.selectalldias(ref mensaje);
            SetBorderAndGridlineStyles();
            bindingSourceGestion.DataSource = BD.test.SelectAllGestion(ref mensaje);

            bindingSourceUsuario.DataSource = BD.test.SelectAllUSUARIO(ref mensaje);
            bindingSourcedemandada.DataSource = BD.ActivitatsORM.SelectAllActividaddemanadas(ref mensaje);
            materialSingleLineTextFieldnom.Text = _act.nombre;
            comboBoxFGestion.SelectedValue = _act.id_tipo;
            comboBox1.SelectedValue = _act.id;
            materialSingleLineTextFieldDia.Text = _act.dias.ToString();
            materialSingleLineTextFieldDurada.Text = _act.durada.ToString();
            comboBoxEquips.SelectedValue = _act.id_espacio;
            if (_act.id_equipo != null)
            {
                comboBoxEquips.SelectedValue = _act.id_equipo;

            }
        }
        private void Horario_Load(object sender, EventArgs e)
        {
            //diasSemanaBindingSource.DataSource = BD.ActivitatsORM.SelectAllDiasSemana(ref mensaje);

            cargardatos();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //    (String Nombre, int id_tipo, int echoid_equipo, int id_act_demandadas, int id_usuario, echo int id_espacio)
            {

                if (materialSingleLineTextFieldnom.Text != "")
                {

                    mensaje = BD.ActivitatsORM.Insertactividad(materialSingleLineTextFieldnom.Text, (int)comboBoxFGestion.SelectedValue, (int)comboBoxEquips.SelectedValue, (int)comboBox1.SelectedValue, (int)comboBoxUsuario.SelectedValue, (int)comboBoxEspai.SelectedValue);
                    mensaje = BD.Horarioactividades.insertathorarios((int)comboBox2.SelectedValue, (int)comboBoxDia.SelectedValue, (TimeSpan)comboBoxHorarioInicio.SelectedValue, (TimeSpan)comboBoxHorariFi.SelectedValue);

                    if (!mensaje.Equals(""))
                    {

                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show("S'ha donat d'alta", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                else
                {
                    MessageBox.Show("Posa el nom indicat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();

            foreach (DataTable dt in my_DataSet.Tables)
            {
                DataTable table = new DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                { table.Columns.Add(Convert.ToString(i)); }

                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    { r[j] = dt.Rows[j - 1][k]; }
                    table.Rows.Add(r);
                }
                ds.Tables.Add(table);
            }

            return ds;
        }
        private void Horario_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void materialRaisedButtonhorario_Click(object sender, EventArgs e)
        {
            mensaje = BD.Horarioactividades.insertathorarios((int)comboBox2.SelectedValue, (int)comboBoxDia.SelectedValue, (TimeSpan)comboBoxHorarioInicio.SelectedValue, (TimeSpan)comboBoxHorariFi.SelectedValue);

            if (!mensaje.Equals(""))
            {

                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("S'ha donat d'alta", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarHorarioporactividad();
        }

        private void cargarHorarioporactividad()
        {

            Act_concedida cambioactividad;//Declaramos nuestra variable de ciudades de la clase Ciudad de nuestro origen de datos. 

            if (comboBox2.SelectedItem != null)//Si tenemos algo seleccionado en nuestra combo ...
            {
                //Enlazamos nuestra comboBox con el nombre de los hoteles.
                cambioactividad = (Act_concedida)comboBox2.SelectedItem;
                bindingSourceHorariocon.DataSource = cambioactividad.Horario_Act_Con.ToList(); //Relacionamos nuestro binding de Hoteles con el item seleccionado en nuestra combo. 
            }

        }

        private void comboBoxHorarioInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Segur que vol eliminar l'Horari ?", "Eliminar Horari", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                Horario_Act_Con Eliminarhorario = (Horario_Act_Con)dataGridView2.CurrentRow.DataBoundItem;
                mensaje = BD.Horarioactividades.DelHorario(Eliminarhorario.id);

                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("S'ha eliminat correctament", "Esborrat", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            mensaje = BD.Horarioactividades.Updatehorari((int)dataGridView2.CurrentRow.Cells[0].Value, (int)comboBox2.SelectedValue, (int)comboBoxDia.SelectedValue, (TimeSpan)comboBoxHorarioInicio.SelectedValue, (TimeSpan)comboBoxHorariFi.SelectedValue);

            if (mensaje.Equals(""))
            {
                MessageBox.Show("S'ha actualitzat", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             comboBox2.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value;
            comboBoxDia.SelectedValue = dataGridView2.CurrentRow.Cells[2].Value;
            comboBoxHorarioInicio.SelectedValue = dataGridView2.CurrentRow.Cells[3].Value;

            comboBoxHorariFi.SelectedValue = dataGridView2.CurrentRow.Cells[4].Value;

      

        }

        private void materialRaisedButtonTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
