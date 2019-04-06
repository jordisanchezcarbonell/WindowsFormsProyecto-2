using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class Exportacion_Resumen : Estilo
    {
        String mensaje = "";
        public Exportacion_Resumen()
        {
            InitializeComponent();
        }
        private void cargardatos()
        {
            bindingSourceEquips.DataSource = BD.Equipos.SELECTEQUIPO(ref mensaje);
            bindingSourceTipusCompeticio.DataSource = BD.Equipos.selectcompeticion(ref mensaje);
            bindingSourceCatXedat.DataSource = BD.Equipos.categoria(ref mensaje);
            bindingSourceEntitat.DataSource = BD.Equipos.SelectAllEntidades(ref mensaje);
            bindingSourcetest.DataSource = BD.SexoORM.SelectSexo(ref mensaje);
        }
        private void Exportacion_Resumen_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void Equips_CheckedChanged(object sender, EventArgs e)
        {
            //E entidad2;


        if (Equips.Checked == true) {
                dataGridViewEquips.DataSource = bindingSourceEquips; //Relaci
            }
            else
            {
                dataGridViewEquips.DataSource = null;

            }

        }

        private void tipuscompeticio_CheckedChanged(object sender, EventArgs e)
        {
            if (tipuscompeticio.Checked == true)
            {
                dataGridViewEquips.DataSource = bindingSourceEntitat;
            }
            else
            {
                dataGridViewEquips.DataSource = null;

            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonTesT_Click(object sender, EventArgs e)
        {
            To_pdf();
        }
        private void To_pdf()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "Autorizo:  ADMIN";
                string envio = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte de General Usuarios", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("ADMIN"));
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }

        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridViewEquips.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridViewEquips);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridViewEquips.ColumnCount; i++)
            {
                datatable.AddCell(dataGridViewEquips.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridViewEquips.Rows.Count; i++)
            {
                for (j = 0; j < dataGridViewEquips.Columns.Count; j++)
                {
                    if (dataGridViewEquips[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridViewEquips[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exportacion_Resumen_Activated(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void Entidad_CheckedChanged(object sender, EventArgs e)
        {
            //bindingSourceTipusCompeticio;
            dataGridViewEquips.DataSource = bindingSourceTipusCompeticio;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
