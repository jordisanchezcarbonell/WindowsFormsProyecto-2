using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class EntitatsORM
    {
        public static string SelectAllEntitats(ref List<Entidad> llistaEntitats)
        {
            string missatgeRetornar = "";

            try
            {
                llistaEntitats = (
                    from entitat in ORM.bd.Entidad
                    select entitat
                    ).ToList();

            } catch (EntityException ex)
            {
                //La SqlException és una subclasse de EntityException:
                SqlException sqlEx = (SqlException)ex.InnerException;
                
                //Envio la SqlException i el mètode em retorna la string corresponent a aquell error:
                missatgeRetornar = ORM.MensajeError(sqlEx);
            }

            return missatgeRetornar;
        }




    }
}
