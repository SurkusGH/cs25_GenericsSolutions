using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions.Soulutions_cs26
{
    public class Solution_07
    {
        //Sukurkite generic tipo validacijos klasę/metodą, tikrinančią ar perduota T reikšmė nėra null
        //Šitą validaciją panaudoti visuose pirmosios ir antrosios užduoties metoduose.
        public static dynamic CheckIFInputIsNull(dynamic input)
        {
            if (input != null)
            {
                Console.WriteLine($"{input} is not null");
                return input;
            }
            else {
                Console.WriteLine($"{input} is null");
                return input; }
        } 
    }
}
