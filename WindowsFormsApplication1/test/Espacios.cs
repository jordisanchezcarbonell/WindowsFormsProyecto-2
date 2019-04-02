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
        Espacio TEST;
        public Espacios()
        {
            InitializeComponent();
        }


        private void cargardatos()
        {
           
            bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            bindingSourceEspacios.DataSource = BD.EspaciosORM.SelectAllEspacios();

            
        }
        private void Espacios_Load(object sender, EventArgs e)
        {
            //cargardatos();
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
        private List<KeyValuePair<string, bool>> GenerateYesNo()

        {
            List<KeyValuePair<string, bool>> yesNoChoices = new List<KeyValuePair<string, bool>>();

            yesNoChoices.Add(new KeyValuePair<string, bool>("Yes", true));
            yesNoChoices.Add(new KeyValuePair<string, bool>("No", false));
            return yesNoChoices;
        }
        private void materialRaisedButtonAgregar_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextFieldNombre.Text != "")
            {
                mensaje = BD.EspaciosORM.InsertEspacio(materialSingleLineTextFieldNombre.Text, Convert.ToDouble(materialSingleLineTextFieldPrecio.Text), materialCheckBoxyes.Checked, (int)comboBoxInstalacion.SelectedValue );

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
            mensaje = BD.EspaciosORM.UpdateEspacio((int)dataGridViewEspacios.CurrentRow.Cells[0].Value, materialSingleLineTextFieldNombre.Text, Convert.ToDouble(materialSingleLineTextFieldPrecio.Text), materialCheckBoxyes.Checked);

            if (!mensaje.Equals(""))
            {

                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("S'HA MODIFICAT CORRECTAMENT", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
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

        private void Espacios_Activated(object sender, EventArgs e)
        {
           // cargardatos();
        }

        private void comboBoxExterior_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // OBTENEMOS LOS DATOS SELECIONADOS DE LA TABLA
            this.materialSingleLineTextFieldNombre.Text = dataGridViewEspacios.CurrentRow.Cells[1].Value.ToString();
            materialSingleLineTextFieldPrecio.Text = dataGridViewEspacios.CurrentRow.Cells[2].Value.ToString();
            materialCheckBoxyes.Checked = Convert.ToBoolean(dataGridViewEspacios.CurrentRow.Cells[3].Value);

           
        }
    }
}
