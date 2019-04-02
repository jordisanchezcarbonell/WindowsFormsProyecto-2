using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Equipos
 
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
        public static List<Telefonos> test(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Telefonos> _Entidades = new List<Telefonos>();

            try
            {

                _Entidades = (from c in ORM.bd.Telefonos
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }


        public static List<Equipo> SELECTEQUIPO(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Equipo> _Entidades = new List<Equipo>();

            try
            {

                _Entidades = (from c in ORM.bd.Equipo
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

       }
        public static List<Deportes> selectdeporte(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Deportes> _Entidades = new List<Deportes>();

            try
            {

                _Entidades = (from c in ORM.bd.Deportes
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }
        public static List<Competicion> selectcompeticion(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Competicion> _Entidades = new List<Competicion>();

            try
            {

                _Entidades = (from c in ORM.bd.Competicion
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }

        public static List<Categoria_edad> categoria(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Categoria_edad> _Entidades = new List<Categoria_edad>();

            try
            {

                _Entidades = (from c in ORM.bd.Categoria_edad
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }

        public static List<Categoria> categoriasolo(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Categoria> _Entidades = new List<Categoria>();

            try
            {

                _Entidades = (from c in ORM.bd.Categoria
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Entidades;

        }


        public static List<Sexo> Sexo(ref String mensaje)
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
        public static String InsertarEquipo( String Nombre, int id_sport, int id_competicion,int id_competicion_edad,int id_nivell,int id_sexo,int id_entidad)
        {

            String mensaje = "";

            Equipo newEquipo= new Equipo();
            newEquipo.nombre = Nombre;
            newEquipo.id_sport = id_sport;

            newEquipo.id_competicion = id_competicion;
            newEquipo.id_categoria_edad = id_competicion_edad;
            newEquipo.id_nivel = id_nivell;
            newEquipo.id_sexo = id_sexo;
            newEquipo.id_entidad = id_entidad;
            ORM.bd.Equipo.Add(newEquipo);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }

        public static String UpdateHoteles(int id,String Nombre, int id_sport, int id_competicion, int id_competicion_edad, int id_nivell, int id_sexo, int id_entidad)
        {

            String mensaje = "";
            Equipo newEquipo = ORM.bd.Equipo.Find(id);

            newEquipo.nombre = Nombre;
            newEquipo.id_sport = id_sport;

            newEquipo.id_competicion = id_competicion;
            newEquipo.id_categoria_edad = id_competicion_edad;
            newEquipo.id_nivel = id_nivell;
            newEquipo.id_sexo = id_sexo;
            newEquipo.id_entidad = id_entidad;


            mensaje = ORM.SaveChanges();

            return mensaje;


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

        public static String DeletEquipo (Equipo delEquipo)
        {

            String mensaje = "";
            ORM.bd.Equipo.Remove(delEquipo);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }

    }
}
