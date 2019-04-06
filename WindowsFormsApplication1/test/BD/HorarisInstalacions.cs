using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class HorarisInstalacions
    {
        public static String InsertHorarioInstalacion(int idInstalacion, int idDia, TimeSpan horaInicio, TimeSpan horaFin)
        {
            String mensaje = "";

            Instalacion_Horario horari = new Instalacion_Horario();

            horari.id_instalacion = idInstalacion;
            horari.id_dia_semana = idDia;
            horari.hora_inicio = horaInicio;
            horari.hora_final = horaFin;

            ORM.bd.Instalacion_Horario.Add(horari);

            //ORM.SaveChanges();

            mensaje = ORM.SaveChanges();

            return mensaje;
        }
       
        public static String UpdateHorarioInstalacion(int id, TimeSpan horaInicio, TimeSpan horaFin)
        {
            String mensaje = "";
            Instalacion_Horario instalacion = ORM.bd.Instalacion_Horario.Find(id);

            instalacion.hora_inicio = horaInicio;
            instalacion.hora_final = horaFin;
            mensaje = ORM.SaveChanges();

            return mensaje;
        }


        public static List<Instalacion_Horario> selecthorario()
        {
            List<Instalacion_Horario> _instalaciones =
                (from i in ORM.bd.Instalacion_Horario
                
                 select i
                 ).ToList();

            return _instalaciones;
        }
    }
}
