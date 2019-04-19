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
            bindingSourcehorainicio.DataSource = BD.HorarisInstalacions.selecthorario();
            bindingSourcefin.DataSource = BD.HorarisInstalacions.selecthorario();
           /* dateTimePickerHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraInicio.CustomFormat = "yyyyMMdd hh:mm:ss tt";
            dateTimePickerHoraFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraFin.CustomFormat = "yyyyMMdd hh:mm:ss tt";*/
        }

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
                MessageBox.Show("S'han d'omplir tots els camps", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dateTimePickerHoraInicio.Value > dateTimePickerHoraFin.Value)
            {
                MessageBox.Show("La hora d'inici ha de ser anterior a la de final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DateTime dt = dateTimePickerHoraInicio.Value;
                TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

                DateTime dt2 = dateTimePickerHoraFin.Value;

                TimeSpan st2 = new TimeSpan(dt2.Hour, dt2.Minute, dt2.Second);
                mensaje = BD.HorarisInstalacions.InsertHorarioInstalacion((int)comboBoxInstalacion.SelectedValue, (int)comboBoxDias.SelectedValue, st, st2);
                MessageBox.Show("S'ha guardat l'horari", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    }
}

