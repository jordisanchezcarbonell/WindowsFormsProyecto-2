using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class DiasORM
    {
        public static List<Dias_Semana> SelectAllDias()
        {
            List<Dias_Semana> _dias =
                (from d in ORM.bd.Dias_Semana
                     //     orderby i.nombre
                 select d
                 ).ToList();

            return _dias;
        }
    }
}
