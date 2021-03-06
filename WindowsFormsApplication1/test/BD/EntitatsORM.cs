﻿using BlowFishCS;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    public class EntitatsORM
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


        public static string InsertEntitat(string nom, int temporada, string adreca, string nif, string correu, string contrasenya)
        {
            string missatgeRetornar = "";

            //Creo un nou objecte entitat,i li guardo els paràmetres que rebo amb el mètode
            Entidad novaEntitat = new Entidad();
            novaEntitat.nombre = nom;
            novaEntitat.temporada = temporada;
            novaEntitat.direccion = adreca;
            novaEntitat.nif = nif;
            novaEntitat.correo = correu;
            novaEntitat.contrasenya = contrasenya;
            
            //Afegeixo l'objecte a la base de dades i guardo els canvis:
            ORM.bd.Entidad.Add(novaEntitat);
            missatgeRetornar = ORM.SaveChanges();

            return missatgeRetornar;
        }


        public static string UpdateEntitat(int id, string nom, int temporada, string adreca, string nif, string correu, string contrasenya)
        {
            string missatgeRetornar = "";

            //Recupero l'objecte entitat buscant-lo amb el seu id, i li setejo tots els camps del formulari (que passo
            //per paràmetre:
            Entidad entitatModificar = ORM.bd.Entidad.Find(id);
            entitatModificar.nombre = nom;
            entitatModificar.temporada = temporada;
            entitatModificar.direccion = adreca;
            entitatModificar.nif = nif;
            entitatModificar.correo = correu;
            entitatModificar.contrasenya = contrasenya;

            missatgeRetornar = ORM.SaveChanges();

            return missatgeRetornar;
        }

        
        public static string deleteEntitat(int id)
        {
            string missatge = "";

            //Busco amb el nif la entitat que vull esborrar, i l'esborro. Després guardo els canvis a la base de dades
            //Si em retorna una string buida, voldrà dir que la operació ha anat bé.
            Entidad entitatEsborrar = ORM.bd.Entidad.Find(id);
            ORM.bd.Entidad.Remove(entitatEsborrar);

            missatge = ORM.SaveChanges();

            return missatge;
        }

    }
}
