using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class ActivitatsORM
    {
        public static List<Act_demandadas> SelectAllActividaddemanadas(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Act_demandadas> _Actdemandadas = new List<Act_demandadas>();

            try
            {

                _Actdemandadas = (from c in ORM.bd.Act_demandadas
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Actdemandadas;

        }

        public static List<Act_concedida> SelectAllActconcedida(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Act_concedida> _Actconcedidas = new List<Act_concedida>();

            try
            {

                _Actconcedidas = (from c in ORM.bd.Act_concedida
                                  select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Actconcedidas;

        }

        public static List<Horario_Act_Dem> SelectAllActdem(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Horario_Act_Dem> _Act_demandadas = new List<Horario_Act_Dem>();

            try
            {

                _Act_demandadas = (from c in ORM.bd.Horario_Act_Dem
                                   select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Act_demandadas;

        }
        public static List<Espacio> SelectAllEspacio(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Espacio> _Espacio = new List<Espacio>();

            try
            {

                _Espacio = (from c in ORM.bd.Espacio
                                  select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Espacio;

        }

        public static List<Horario_Act_Dem> SelectAllHorario_Act_Dem(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Horario_Act_Dem> _Espacio = new List<Horario_Act_Dem>();

            try
            {

                _Espacio = (from c in ORM.bd.Horario_Act_Dem
                            select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Espacio;

        }
        public static List<Horario_Act_Con> SelectAllHorario_Act_Con(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Horario_Act_Con> _Espacio = new List<Horario_Act_Con>();

            try
            {

                _Espacio = (from c in ORM.bd.Horario_Act_Con
                            select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Espacio;

        }
        public static List<Dias_Semana> SelectAllDiasSemana(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Dias_Semana> _DiasSemana = new List<Dias_Semana>();

            try
            {

                _DiasSemana = (from c in ORM.bd.Dias_Semana
                            select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _DiasSemana;

        }

        public static String Insertactividad(String Nombre, int id_tipo, int id_equipo, int id_act_demandadas, int id_usuario, int id_espacio)
        {

            String mensaje = "";

            Act_concedida newActividad = new Act_concedida();
            newActividad.nombre = Nombre;
            newActividad.id_tipo = id_tipo;

            newActividad.id_equipo = id_equipo;
            newActividad.id_act_demandadas = id_act_demandadas;
            newActividad.id_usuario = id_usuario;
            newActividad.id_espacio = id_espacio;
           
            ORM.bd.Act_concedida.Add(newActividad);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }
    }
}
