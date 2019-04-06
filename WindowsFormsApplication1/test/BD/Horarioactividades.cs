using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI.BD
{
    class Horarioactividades
    {
        public static String insertathorarios( int id_act_concedida, int id_dia_semana, TimeSpan hora_inicio,TimeSpan hora_fin)
        {

            String mensaje = "";

            Horario_Act_Con newHorario= new Horario_Act_Con();
            newHorario.id_act_concedida = id_act_concedida;
            newHorario.id_dia_semana= id_dia_semana;

            newHorario.hora_inicio = hora_inicio;
            newHorario.hora_fin = hora_fin;
         

            ORM.bd.Horario_Act_Con.Add(newHorario);

            mensaje = ORM.SaveChanges();

            return mensaje;


        }
        public static String Updatehorari(int id, int id_act_concedida, int id_dia_semana, TimeSpan hora_inicio, TimeSpan hora_fin)
        {

            String mensaje = "";
            Horario_Act_Con newHorario  = ORM.bd.Horario_Act_Con.Find(id);

            newHorario.id_act_concedida = id_act_concedida;
            newHorario.id_dia_semana = id_dia_semana;

            newHorario.hora_inicio = hora_inicio;
            newHorario.hora_fin = hora_fin;


            mensaje = ORM.SaveChanges();

            return mensaje;


        }

        public static String DelHorario(int id)
        {

            String mensaje = "";
            Horario_Act_Con delhorario = ORM.bd.Horario_Act_Con.Find(id);
            ORM.bd.Horario_Act_Con.Remove(delhorario);

            mensaje = ORM.SaveChanges();

            return mensaje;
        }
    }
}
