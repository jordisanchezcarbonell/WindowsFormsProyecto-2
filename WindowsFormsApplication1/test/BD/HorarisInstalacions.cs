using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class HorarisInstalacions
    {
        public static void InsertHorariInstalacio(int idInstalacio, int idDia, TimeSpan horaInici, TimeSpan horaFi)
        {
            Instalacion_Horario horari = new Instalacion_Horario();
            horari.id_instalacion = idInstalacio;
            horari.id_dia_semana = idDia;
            horari.hora_inicio = horaInici;
            horari.hora_final = horaFi;
        }
    }
}
