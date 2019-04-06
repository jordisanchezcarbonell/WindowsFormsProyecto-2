using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Espais
    {

        String mensaje = "";
        public static List<Espacio> SelectAllEspais(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Espacio> _Espais = new List<Espacio>();

            try
            {

                _Espais = (from c in ORM.bd.Espacio
                                  select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Espais;

        }
    }
}
