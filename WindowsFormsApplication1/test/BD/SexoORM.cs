using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class SexoORM
    {
        public static List<Sexo> SelectSexo(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Sexo> _Entidades = new List<Sexo>();

            try
            {

                _Entidades = (from c in ORM.bd.Sexo
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }
    }
}
