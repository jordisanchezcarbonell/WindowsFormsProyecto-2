using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class test
    {
        public static List<Tipo_gestion> SelectAllGestion(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Tipo_gestion> _Gestion= new List<Tipo_gestion>();

            try
            {

                _Gestion = (from c in ORM.bd.Tipo_gestion
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Gestion;

        }
        public static List<Usuario> SelectAllUSUARIO(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Usuario> _User = new List<Usuario>();

            try
            {

                _User = (from c in ORM.bd.Usuario
                            select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _User;

        }
       
    }
}
