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

        private void cargardatos()
        {
            bindingSourceInstalaciones.DataSource = BD.InstalacionsORM.SelectAllInstalaciones();
            bindingSourceEspacios.DataSource = BD.EspaciosORM.SelectAllEspacios();
            dataGridViewEspacios.AutoResizeColumns();
            dataGridViewEspacios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Espacios_Load(object sender, EventArgs e)
        {
            cargardatos();
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
                mensaje = BD.EspaciosORM.InsertEspacio(materialSingleLineTextFieldNombre.Text, Convert.ToDouble(materialSingleLineTextFieldPrecio.Text), (int)comboBoxInstalacion.SelectedValue, (Boolean)checkBoxExterior.Checked);

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
                MessageBox.Show("Posa el nom indicat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextFieldNombre.Text.Equals("") || materialSingleLineTextFieldPrecio.Text.Equals(""))
            {
                MessageBox.Show("Introdueix un nom i un preu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mensaje = BD.EspaciosORM.UpdateEspacio((int)dataGridViewEspacios.CurrentRow.Cells[0].Value, materialSingleLineTextFieldNombre.Text, Double.Parse(materialSingleLineTextFieldPrecio.Text), (Boolean)checkBoxExterior.Checked);

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



        private void materialSingleLineTextFieldPrecio_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Segur que vols eliminar el registre?", "Eliminar Registre", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                Espacio espacio = (Espacio)dataGridViewEspacios.CurrentRow.DataBoundItem;
                mensaje = BD.EspaciosORM.DeleteEspacio(espacio.id);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                
                    MessageBox.Show("S'ha esborrat correctament!", "Esborrat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
        }

        private void Espacios_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dataGridViewEspacios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            materialSingleLineTextFieldNombre.Text = dataGridViewEspacios.CurrentRow.Cells[1].Value.ToString();
            comboBoxInstalacion.SelectedValue = dataGridViewEspacios.CurrentRow.Cells[4].Value;
            materialSingleLineTextFieldPrecio.Text = dataGridViewEspacios.CurrentRow.Cells[2].Value.ToString();
            checkBoxExterior.Checked = Convert.ToBoolean(dataGridViewEspacios.CurrentRow.Cells[3].Value);
        }
    }
}
