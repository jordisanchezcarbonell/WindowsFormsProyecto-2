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
    public partial class HorariInstalacio : Estilo
    {
        public HorariInstalacio()
        {
            InitializeComponent();
        }

        private void HorariInstalacio_Load(object sender, EventArgs e)
        {
            bindingSourceInstalaciones.DataSource = BD.InstalacionsORM.SelectAllInstalaciones();
            bindingSourceDiasSemana.DataSource = BD.DiasORM.SelectAllDias();
        }
    }
}
