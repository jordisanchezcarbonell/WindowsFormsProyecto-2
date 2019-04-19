using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace COMPLETE_FLAT_UI
{
    public partial class Equipos : Estilo
    {
        String mensaje = "";
        public Equipos()
        {
            InitializeComponent();
        }

        private void cargardatos()
        {
            bindingSourceEquips.DataSource = BD.Equipos.SELECTEQUIPO(ref mensaje);
            bindingSourceEsports.DataSource = BD.Equipos.selectdeporte(ref mensaje);
            bindingSourceTipusCompeticio.DataSource = BD.Equipos.selectcompeticion(ref mensaje);
            bindingSourceCatXedat.DataSource = BD.Equipos.categoria(ref mensaje);
            bindingSourcecategoriasolo.DataSource = BD.Equipos.categoriasolo(ref mensaje);
            bindingSourcesexo.DataSource = BD.SexoORM.SelectSexo(ref mensaje);
            bindingSourceEntitat.DataSource = BD.Equipos.SelectAllEntidades(ref mensaje);
        }

        private void Instalaciones_Load(object sender, EventArgs e)
        {
            

        }

        private void Instalaciones_Load_1(object sender, EventArgs e)
        {


            cargardatos();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonAfegir_Click(object sender, EventArgs e)
        {

            if(materialSingleLineTextFieldNom.Text != "") { 

                     mensaje = BD.Equipos.InsertarEquipo(materialSingleLineTextFieldNom.Text, (int)comboBoxEsport.SelectedValue, (int)comboBoxTipusCompeticio.SelectedValue, (int)comboBoxCategoriaEdat.SelectedValue, (int)comboBoxCategoria.SelectedValue, (int)comboBoxSexe.SelectedValue,(int)comboBoxEntidad.SelectedValue);

                    if (!mensaje.Equals(""))
                    {

                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show("S'ha donat d'alta", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         cargardatos();


                }
            }
            else
            {
                MessageBox.Show("Posa el nom indicat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void materialRaisedButtonEsborrar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Segur que vol eliminar el Registre?", "Eliminar Registre", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {


                //aqui el codigo para eliminar el registro
                Equipo Equipotest = (Equipo)dataGridViewEquips.CurrentRow.DataBoundItem;
                mensaje = BD.Equipos.DeletEquipo(Equipotest.id);

                if (!mensaje.Equals(""))
                {
                    
                     MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("S'ha eliminat correctament", "Esborrat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargardatos();


                }


            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //OBTENEMOS LOS DATOS SELECIONADOS DE LA TABLA
            this.materialSingleLineTextFieldNom.Text = dataGridViewEquips.CurrentRow.Cells[1].Value.ToString();
            comboBoxEsport.SelectedValue = dataGridViewEquips.CurrentRow.Cells[2].Value;
            comboBoxTipusCompeticio.SelectedValue = dataGridViewEquips.CurrentRow.Cells[3].Value;

            comboBoxCategoriaEdat.SelectedValue = dataGridViewEquips.CurrentRow.Cells[4].Value;
            comboBoxCategoria.SelectedValue = dataGridViewEquips.CurrentRow.Cells[5].Value;
            comboBoxSexe.SelectedValue = dataGridViewEquips.CurrentRow.Cells[6].Value;


        }

        private void Instalaciones_Activated(object sender, EventArgs e)
        {
            bindingSourceEquips.DataSource = BD.Equipos.SELECTEQUIPO(ref mensaje);

        }

        private void materialRaisedButtonModificar_Click(object sender, EventArgs e)
        {
            mensaje = BD.Equipos.UpdateEquipos((int)dataGridViewEquips.CurrentRow.Cells[0].Value,materialSingleLineTextFieldNom.Text, (int)comboBoxEsport.SelectedValue, (int)comboBoxTipusCompeticio.SelectedValue, (int)comboBoxCategoriaEdat.SelectedValue, (int)comboBoxCategoria.SelectedValue, (int)comboBoxSexe.SelectedValue,(int)comboBoxEntidad.SelectedValue);

            if (mensaje.Equals(""))
            {
                MessageBox.Show("S'ha modificat", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargardatos();

            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBoxTextsize_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Entidad entidad2;
          
    

            if (comboBoxEntidad.SelectedItem != null)//Si tenemos algo seleccionado en nuestra combo ...
            {
                //Enlazamos nuestra comboBox con el nombre de los hoteles.
                entidad2 = (Entidad)comboBoxEntidad.SelectedItem;
                bindingSourceEquips.DataSource =  entidad2.correo.ToList(); //Relacionamos nuestro binding de Hoteles con el item seleccionado en nuestra combo. 
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            dataGridViewEquips.ClearSelection();

            materialSingleLineTextFieldNom.Clear();
            
           


        }

       

    }
}
