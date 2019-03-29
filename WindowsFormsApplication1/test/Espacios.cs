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
    public partial class Espacios : Estilo
    {
        String mensaje = "";
        public Espacios()
        {
            InitializeComponent();
        }

        private void Espacios_Load(object sender, EventArgs e)
        {
            bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            bindingSourceEspacios.DataSource = BD.EspaciosORM.SelectAllEspacios();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBoxInstalacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instalacion int2;
            if (comboBoxInstalacion.SelectedItem != null)
            {
                int2 = (Instalacion)comboBoxInstalacion.SelectedItem;
                bindingSourceEspacios.DataSource = int2.Espacio.ToList();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonAgregar_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextFieldNombre.Text != "")
            {
                mensaje = BD.EspaciosORM.InsertEspacio(materialSingleLineTextFieldNombre.Text, Convert.ToDouble(materialSingleLineTextFieldPrecio.Text), (int)comboBoxInstalacion.SelectedValue, (Boolean)comboBoxExterior.SelectedValue);

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

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            mensaje = BD.EspaciosORM.UpdateEspacio((int)dataGridViewEspacios.CurrentRow.Cells[0].Value, materialSingleLineTextFieldNombre.Text, Double.Parse(materialSingleLineTextFieldPrecio.Text), (Boolean)comboBoxInstalacion.SelectedValue);
        }



        private void materialSingleLineTextFieldPrecio_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro que quiere eliminar el Registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                mensaje = BD.EspaciosORM.DeleteEspacio((Espacio)dataGridViewEspacios.CurrentRow.DataBoundItem);

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
    }
}
