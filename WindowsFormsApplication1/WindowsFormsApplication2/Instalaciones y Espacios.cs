using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Instalaciones_y_Espacios : MaterialForm
    {
        public Instalaciones_y_Espacios()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue400,
                TextShade.WHITE
            );
        }

        private void Instalaciones_y_Espacios_Load(object sender, EventArgs e)
        {
            /*Modificar el estilo Datagridview*/
            dataGridView1.ForeColor = Color.FromArgb(245, 245, 245);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.GridColor = Color.FromArgb(245, 245, 245);


            dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersHeightSizeMode = false;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 69, 76);
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 144, 144);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
            dataGridView1.BackgroundColor = Color.FromArgb(64, 69, 76);
        }
    }
}
