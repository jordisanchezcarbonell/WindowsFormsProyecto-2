using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Entidades
    {
        //SELECT ALL ENTIDADES
        public static List<Entidad> SelectAllEntidades(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Entidad> _Entidades = new List<Entidad>();

            try
            {

                _Entidades = (from c in ORM.bd.Entidad
                             select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }
        /*
        //INSERT
            public static String InsertHoteles(int id_ciudad,String Nombre,int categoria,String Direccion,int telefono,String tipo,string cif)
        {

            String mensaje = "";

            hoteles newhoteles = new hoteles();
            newhoteles.id_ciudad = id_ciudad;
            newhoteles.nombre = Nombre;
            newhoteles.categoria = categoria;

            newhoteles.direccion = Direccion;
            newhoteles.telefono = telefono;
            newhoteles.tipo = tipo;
            newhoteles.cif = cif;

            ORM.bd.hoteles.Add(newhoteles);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }


            //Update
        public static String UpdateHoteles(int id_ciudad, String Nombre, int categoria, String Direccion, int telefono, String tipo, string cif)
        {

            String mensaje = "";
            hoteles newhoteles = ORM.bd.hoteles.Find(id_ciudad, Nombre);
            newhoteles.id_ciudad = id_ciudad;
            newhoteles.nombre = Nombre;
            newhoteles.categoria = categoria;

            newhoteles.direccion = Direccion;
            newhoteles.telefono = telefono;
            newhoteles.tipo = tipo;
            newhoteles.cif = cif;


            mensaje = ORM.SaveChanges();

            return mensaje;


        }
*/


            //DELETE
        public static String DeleteHotel(Entidad delEntidad)
        {

            String mensaje = "";
            ORM.bd.Entidad.Remove(delEntidad);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

    }
}
