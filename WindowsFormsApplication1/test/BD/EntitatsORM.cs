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


        public static string InsertEntitat(string nom, string temporada, string adreca, string nif, string correu)
        {
            string missatgeRetornar = "";

            Entidad novaEntitat = new Entidad();
            novaEntitat.nombre = nom;
            novaEntitat.temporada = int.Parse(temporada);
            novaEntitat.direccion = adreca;
            novaEntitat.nif = nif;
            novaEntitat.correo = correu;

            ORM.bd.Entidad.Add(novaEntitat);
            //Aquí va: missatgeRetornar = ORM.saveChanges();

            return missatgeRetornar;
        }


        public static string UpdateEntitat(int id, string nom, string temporada, string adreca, string nif, string correu)
        {
            string missatgeRetornar = "";

            Entidad entitatModificar = ORM.bd.Entidad.Find(id);
            entitatModificar.nombre = nom;
            entitatModificar.temporada = int.Parse(temporada);
            entitatModificar.direccion = adreca;
            entitatModificar.nif = nif;
            entitatModificar.correo = correu;

            //Aquí va: missatgeRetornar = ORM.saveChanges();

            return missatgeRetornar;
        }


        //Continuar amb el deleteEntitat i després afegir els mètodes saveChanges i rejectChanges al fitxer ORM

        



    }
}
