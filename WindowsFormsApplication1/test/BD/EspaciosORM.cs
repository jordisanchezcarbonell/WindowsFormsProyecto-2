using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class EspaciosORM
    {
        public static List<Espacio> SelectAllEspacios()
        {
            List<Espacio> _espacios =
                (from e in ORM.bd.Espacio
                 // orderby e.nombre
                 select e
                 ).ToList();

            return _espacios;
        }
        public static String InsertEspacio(String nom, double preu, int idInstalacio, Boolean exterior)
        {
            String mensaje = "";
            Espacio espacio = new Espacio();
            espacio.nombre = nom;
            espacio.precio = preu;
            espacio.id_instalacion = idInstalacio;
            espacio.exterior = exterior;

            ORM.bd.Espacio.Add(espacio);

            ORM.SaveChanges();

            mensaje = ORM.SaveChanges();

            return mensaje;

        }


        public static String UpdateEspacio(int id, String nom, Double preu, Boolean exterior)
        {
            String mensaje = "";
            Espacio espacio = ORM.bd.Espacio.Find(id);

            espacio.nombre = nom;
            espacio.precio = preu;
            espacio.exterior = exterior;
            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        public static String DeleteEspacio(Espacio id)
        {
            String mensaje = "";
            Espacio espacio = ORM.bd.Espacio.Find(id);

            ORM.bd.Espacio.Remove(id);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }


    }



}

