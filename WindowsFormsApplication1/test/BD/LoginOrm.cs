using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class LoginOrm
    {


        public static Admin selectAdmins(String nom, String contra)
        {
            Admin listaAdmins =
                (from admin in ORM.bd.Admin
                 where admin.nombre.Equals(nom) && admin.contrasenya.Equals(contra)
                 select admin
                 ).FirstOrDefault();
            return listaAdmins;
        }

        public static List<Admin> SelectAllAdmin(ref String mensaje)
        {
            /*PRIMERO FROM DESPUES EL SELECT*/
            List<Admin> _Admin = new List<Admin>();

            try
            {

                _Admin = (from c in ORM.bd.Admin
                              select c).ToList();
            }
            catch (SqlException ex)
            {
                mensaje = ORM.MensajeError(ex);
            }

            return _Admin;

        }
        public static String InsertarAdmin(String Nombre,String email,String contrasenya)
        {

            String mensaje = "";

            Admin newAdmin = new Admin();
            newAdmin.nombre = Nombre;
            newAdmin.correo = email;
            newAdmin.contrasenya = contrasenya;
            ORM.bd.Admin.Add(newAdmin);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }

        public static String UpgradeAdmin(int id ,String Nombre, String email, String contrasenya)
        {

            String mensaje = "";

            Admin adminModificar = ORM.bd.Admin.Find(id);
            adminModificar.nombre = Nombre;
            adminModificar.correo = email;
            adminModificar.contrasenya = contrasenya;
            

            mensaje = ORM.SaveChanges();

            return mensaje;


        }

        public static String Deleteadmin(int id)
        {

            String mensaje = "";

            Admin adminEsborra = ORM.bd.Admin.Find(id);
            ORM.bd.Admin.Remove(adminEsborra);
            mensaje = ORM.SaveChanges();
            return mensaje;


        }
      

    }
}
