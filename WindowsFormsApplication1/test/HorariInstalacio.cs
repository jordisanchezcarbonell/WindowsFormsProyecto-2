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
        String mensaje;
        public HorariInstalacio()
        {
            InitializeComponent();
        }

        private void HorariInstalacio_Load(object sender, EventArgs e)
        {
            bindingSourceInstalaciones.DataSource = BD.InstalacionsORM.SelectAllInstalaciones();
            bindingSourceDiasSemana.DataSource = BD.DiasORM.SelectAllDias();
            dateTimePickerHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraInicio.CustomFormat = "HH:mm:ss";
        }
/*
        private void dateTimePickerHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            if (picker == null) return;

            DateTime d = DateTime.Now;
            var ts = d.Subtract(picker.Value);
        }

        private void dateTimePickerHoraFin_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            if (picker == null) return;

            DateTime d = DateTime.Now;
            var ts = d.Subtract(picker.Value);
        }

        private void materialRaisedButtonAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxInstalacion.SelectedValue.Equals(null) || comboBoxInstalacion.SelectedValue.Equals(null) || dateTimePickerHoraInicio.Value.Equals(null) || dateTimePickerHoraFin.Value.Equals(null))
            {
                MessageBox.Show("Omple tots els camps", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mensaje = BD.HorarisInstalacions.InsertHorarioInstalacion((int)comboBoxInstalacion.SelectedValue, (int)comboBoxDias.SelectedValue, Convert.ToDateTime(dateTimePickerHoraInicio.Text), Convert.ToDateTime(dateTimePickerHoraFin.Text));
                MessageBox.Show("S'ha guardat l'horari", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        */

    }
}

