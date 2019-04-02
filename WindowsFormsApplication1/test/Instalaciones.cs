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

        String mensaje = "";
        public Instalaciones()
        {
            InitializeComponent();
        }
        private void cargardatos()
        {

            bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            bindingSourceTipoGestion.DataSource = BD.TipusGestio.SelectAllTipoGestion();
            bindingSourceDiasSemana.DataSource = BD.DiasORM.SelectAllDias();
        }

        private void Instalaciones_Load(object sender, EventArgs e)
        {


        }

        private void Instalaciones_Load_1(object sender, EventArgs e)
        {

            // bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            cargardatos();


        }

        private void materialSingleLineTextFieldTitulo_TextChanged(object sender, EventArgs e)
        {
            //bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectInstalacionesByNombre(materialSingleLineTextFieldTitulo.Text);
        }

        private void materialSingleLineTextFieldTitulo_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Instalaciones_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void materialRaisedButtonAgregar_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextFieldNombre.Text != "")
            {
                //(String nom, String adreca, int idTipoGestion)//


                mensaje = BD.Instalacions.InsertInstalacion(materialSingleLineTextFieldNombre.Text, materialSingleLineTextFieldAdreca.Text, (int)comboBoxEsport.SelectedValue);

                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("SE HA DADO DE ALTA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else
            {
                MessageBox.Show("Posa el nom indicat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void materialRaisedButtonBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                mensaje = BD.Instalacions.DeleteInstalacion((Instalacion)dataGridViewInstalaciones.CurrentRow.DataBoundItem);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show(mensaje, "BORRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
        }

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            mensaje = BD.Instalacions.UpdateInstalacion((int)dataGridViewInstalaciones.CurrentRow.Cells[0].Value, materialSingleLineTextFieldNombre.Text, materialSingleLineTextFieldAdreca.Text, (int)comboBoxEsport.SelectedValue);
        }

        private void dataGridViewInstalaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.materialSingleLineTextFieldNombre.Text = dataGridViewInstalaciones.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextFieldAdreca.Text = dataGridViewInstalaciones.CurrentRow.Cells[3].Value.ToString();
            comboBoxEsport.SelectedValue = dataGridViewInstalaciones.CurrentRow.Cells[2].Value;
            

        }

        private void materialSingleLineTextFieldAdreca_Click(object sender, EventArgs e)
        {

        }
    }
}
