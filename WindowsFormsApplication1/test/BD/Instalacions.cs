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

        public static String InsertInstalacion(String nom, String adreca, int idTipoGestion)
        {
            String mensaje = "";
            Instalacion instalacion = new Instalacion();
            instalacion.nombre = nom;
            instalacion.direccion = adreca;
            instalacion.id_tipo_gestion = idTipoGestion;

            ORM.bd.Instalacion.Add(instalacion);

            ORM.SaveChanges();

            mensaje = ORM.SaveChanges();

            return mensaje;

        }

     
        public static String UpdateInstalacion(int id, String nom, String adreca, int idTipoGestion)
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
