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
        public static String InsertEspacio(String nom, double preu, int idInstalacio)
        {
            String mensaje = "";
            Espacio espacio = new Espacio();
            espacio.nombre = nom;
            espacio.precio = preu;
            espacio.id_instalacion = idInstalacio;

            ORM.bd.Espacio.Add(espacio);

            ORM.SaveChanges();

            mensaje = ORM.SaveChanges();

            return mensaje;

        }


        public static String UpdateEspacio(int id, String nom, String adreca, int idTipoGestion)
        {
            String mensaje = "";
            Instalacion instalacion = ORM.bd.Instalacion.Find(id);

            instalacion.nombre = nom;
            instalacion.direccion = adreca;
            instalacion.id_tipo_gestion = idTipoGestion;
            mensaje = ORM.SaveChanges();

            return mensaje;
        }

        public static String DeleteInstalacion(Instalacion id)
        {
            String mensaje = "";
            //Instalacion instalacion = ORM.bd.Instalacion.Find(id);

            ORM.bd.Instalacion.Remove(id);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }


    }



}

