using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class TelefonsORM
    {
        public static string SelectAllTelefons(ref List<Telefonos> llistaTelefons)
        {
            string missatgeRetornar = "";

            try
            {
                llistaTelefons = (
                    from telefon in ORM.bd.Telefonos
                    select telefon
                    ).ToList();

            }
            catch (EntityException ex)
            {
                //La SqlException és una subclasse de EntityException:
                SqlException sqlEx = (SqlException)ex.InnerException;

                //Envio la SqlException i el mètode em retorna la string corresponent a aquell error:
                missatgeRetornar = ORM.MensajeError(sqlEx);
            }

            return missatgeRetornar;
        }


        public static string InsertTelefon(string telefon, string rao, int entitat)
        {
            string missatgeRetornar = "";

            //Creo un nou objecte telefonos,i li guardo els paràmetres que rebo amb el mètode
            Telefonos nouTelefon = new Telefonos();
            nouTelefon.telefono = telefon;
            nouTelefon.razon = rao;
            nouTelefon.id_entidad = entitat;

            //Afegeixo l'objecte a la base de dades i guardo els canvis:
            ORM.bd.Telefonos.Add(nouTelefon);
            missatgeRetornar = ORM.SaveChanges();

            return missatgeRetornar;
        }


        public static string UpdateTelefon(int id, string telefon, string rao, int entitat)
        {
            string missatgeRetornar = "";

            //Recupero l'objecte entitat buscant-lo amb el seu id, i li setejo tots els camps del formulari (que passo
            //per paràmetre:
            Telefonos telefonModificar = ORM.bd.Telefonos.Find(id);
            telefonModificar.telefono = telefon;
            telefonModificar.razon = rao;
            telefonModificar.id_entidad = entitat;

            missatgeRetornar = ORM.SaveChanges();

            return missatgeRetornar;
        }


        public static string deleteTelefon(int id)
        {
            string missatge = "";

            //Busco amb el nif el telèfon que vull esborrar, i l'esborro. Després guardo els canvis a la base de dades
            //Si em retorna una string buida, voldrà dir que la operació ha anat bé.
            Telefonos telefonEsborrar = ORM.bd.Telefonos.Find(id);
            ORM.bd.Telefonos.Remove(telefonEsborrar);

            missatge = ORM.SaveChanges();

            return missatge;
        }




    }
}
