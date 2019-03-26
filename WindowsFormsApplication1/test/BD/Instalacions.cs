using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Instalacions
    {

        public static void InsertInstalacion(String nom, String adreca, int tipoGestion)
        {
            Instalacion instalacion = new Instalacion();
            instalacion.nombre = nom;
            instalacion.direccion = adreca;
            instalacion.id_tipo_gestion = tipoGestion;
        }

        public static void UpdateInstalacion(int id, String nom, String adreca, int idTipoGestion)
        {

        }
        


    }
}
