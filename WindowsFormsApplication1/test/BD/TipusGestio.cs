using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class TipusGestio
    {
        public static List<Tipo_gestion> SelectAllTipoGestion()
        {
        


            List<Tipo_gestion> _tipoGestion =
                (from tg in ORM.bd.Tipo_gestion
                     //     orderby i.nombre
                 select tg
                 ).ToList();

            return _tipoGestion;
        }

    }
}
