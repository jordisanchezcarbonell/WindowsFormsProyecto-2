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

            bindingSourceInstalaciones.DataSource = BD.InstalacionsORM.SelectAllInstalaciones();
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
            materialSingleLineTextFieldNombre.Text = dataGridViewInstalaciones.CurrentRow.Cells[1].Value.ToString();
            comboBoxEsport.SelectedValue = dataGridViewInstalaciones.CurrentRow.Cells[2].Value;
            materialSingleLineTextFieldAdreca.Text = dataGridViewInstalaciones.CurrentRow.Cells[3].Value.ToString();
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


                mensaje = BD.InstalacionsORM.InsertInstalacion(materialSingleLineTextFieldNombre.Text, materialSingleLineTextFieldAdreca.Text, (int)comboBoxEsport.SelectedValue);

                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("S'ha donat d'alta correctament", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

                Instalacion instalacion = (Instalacion)dataGridViewInstalaciones.CurrentRow.DataBoundItem;
                mensaje = BD.InstalacionsORM.DeleteInstalacion(instalacion.id);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show("S'ha esborrat correctament", "ESBORRAT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
        }

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {

            if (materialSingleLineTextFieldNombre.Text.Equals("") || materialSingleLineTextFieldAdreca.Text.Equals(""))
            {
                MessageBox.Show("Introdueix un nom i una adreça", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mensaje = BD.InstalacionsORM.UpdateInstalacion((int)dataGridViewInstalaciones.CurrentRow.Cells[0].Value, materialSingleLineTextFieldNombre.Text, materialSingleLineTextFieldAdreca.Text, (int)comboBoxEsport.SelectedValue);

                if (mensaje.Equals(""))

                {
                    MessageBox.Show("S'ha modificat correctament!", "MODIFICAT", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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

        private void materialRaisedButtonHorari_Click(object sender, EventArgs e)
        {
            HorariInstalacio hi = new HorariInstalacio();
            hi.ShowDialog();
        }
    }
}
