using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Instalacions
    {

        public static List<Instalacion> SelectAllInstalaciones()
        {
            List<Instalacion> _instalaciones =
                (from i in ORM.bd.Instalacion
            //     orderby i.nombre
                 select i
                 ).ToList();

            return _instalaciones;
        }

        public static List<Instalacion> SelectInstalacionesByNombre(String nombre)
        {
            List<Instalacion> _instalaciones =
                (from i in ORM.bd.Instalacion
                 where i.nombre.Contains(nombre)
                 orderby i.nombre
                 select i
                 ).ToList();

            return _instalaciones;
        }

        public static void InsertInstalacion(String nom, String adreca, int idTipoGestion)
        {
            Instalacion instalacion = new Instalacion();
            instalacion.nombre = nom;
            instalacion.direccion = adreca;
            instalacion.id_tipo_gestion = idTipoGestion;

            ORM.SaveChanges();
        }

        public static void UpdateInstalacion(int id, String nom, String adreca, int idTipoGestion)
        {
            Instalacion instalacion = ORM.bd.Instalacion.Find(id);

            instalacion.nombre = nom;
            instalacion.direccion = adreca;
            instalacion.id_tipo_gestion = idTipoGestion;

            ORM.SaveChanges();
        }

        public static void DeleteInstalacion(int id)
        {
            Instalacion instalacion = ORM.bd.Instalacion.Find(id);

            ORM.bd.Instalacion.Remove(instalacion);

            ORM.SaveChanges();
        }


    }
}
