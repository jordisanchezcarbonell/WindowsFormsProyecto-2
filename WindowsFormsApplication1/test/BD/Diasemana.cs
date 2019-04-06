using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Diasemana
    {
        public static List<Dias_Semana> selectalldias(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Dias_Semana> _Dia = new List<Dias_Semana>();

            try
            {

                _Dia = (from c in ORM.bd.Dias_Semana
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Dia;

        }
    }
}
