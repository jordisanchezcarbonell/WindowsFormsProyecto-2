using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class HorarisInstalacions
    {
        public static void InsertHorarioInstalacion(int idInstalacion, int idDia, DateTime horaInicio, DateTime horaFin)
        {
            Instalacion_Horario horari = new Instalacion_Horario();
            horari.id_instalacion = idInstalacion;
            horari.id_dia_semana = idDia;
            horari.hora_inicio = horaInicio;
            horari.hora_final = horaFin;
        }

        public static String UpdateHorarioInstalacion(int id, DateTime horaInicio, DateTime horaFin)
        {
            String mensaje = "";
            Instalacion_Horario instalacion = ORM.bd.Instalacion_Horario.Find(id);

            instalacion.hora_inicio = horaInicio;
            instalacion.hora_final = horaFin;
            mensaje = ORM.SaveChanges();

            return mensaje;
        }

    }
}
