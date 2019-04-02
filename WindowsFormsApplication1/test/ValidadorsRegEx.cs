using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMPLETE_FLAT_UI
{
    public static class ValidadorsRegEx
    {
        //Origen d'aquest mètode: https://stackoverflow.com/questions/16167983/best-regular-expression-for-email-validation-in-c-sharp/16168118
        //És una fusió de la 2a i 4a entrada:
        public static bool validarCorreu(string inputEmail)
        {
            bool resultat = Regex.IsMatch(inputEmail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            return resultat;
        }


        public static bool validarNifEspanyol(string nif)
        {
            //bool resultat = Regex.IsMatch(nif, @"/^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$"); --> No funciona pq té la barra davant (és de JavaScript)
            bool resultat = Regex.IsMatch(nif, @"[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]");

            return resultat;
        }
    }
}
