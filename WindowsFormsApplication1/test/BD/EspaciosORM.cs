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

     /*   public static List<Espacio> SelectEspaciosByInstalacion(int id_instalacion)
        {
            List<Espacio> _espacios =
                (from e in ORM.bd.Espacio
                 where e.id_instalacion.Contains(id_instalacion)
                 // orderby e.nombre
                 select e
                 ).ToList();

            return _espacios;
        }
        */
    }
}
