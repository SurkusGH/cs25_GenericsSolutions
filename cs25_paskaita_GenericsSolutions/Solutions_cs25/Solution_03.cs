using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions.Solutions
{
    public class Solution_03 <T>
    {
        // Sukurkite klasę Calculator, kuri priims du type T tipo kintamuosius
        public T Variable1 { get; set; }
        public T Variable2 { get; set; }

        public Solution_03(T variable1, T variable2)
        {
            Variable1 = variable1;
            Variable2 = variable2;
        }

        // Turės funkcijas tuos kintamuosius sudėti, atimti, sudauginti ir padalinti
        public void ValueAddition()
        {
            Validate();
            dynamic x = Variable1;
            dynamic y = Variable2;
            Console.WriteLine($"{Variable1} + {Variable2} = {x + y}");
        }
        public void ValueSubstraction()
        {
            Validate();
            dynamic x = Variable1;
            dynamic y = Variable2;
            Console.WriteLine($"{Variable1} - {Variable2} = {x - y}");
        }

        public void ValueMultiplication()
        {
            Validate();
            dynamic x = Variable1;
            dynamic y = Variable2;
            Console.WriteLine($"{Variable1} * {Variable2} = {x * y}");
        }
        public void ValueDivision()
        {
            dynamic x = Variable1;
            dynamic y = Variable2;
            Console.WriteLine($"{Variable1} / {Variable2} = {x / y}");
        }

        // Taip pat turės funkciją Validate, kuri patikrins ar kintamųjų tipai yra skaičiai
        // šią funkciją kvies prieš sudėtį, atimtį, saundaugą ar dalybą
        public void Validate()
        {
            if (typeof(T) == typeof(int))
            {
                Console.WriteLine($"Įvestis yra Type - Int");
            }
            else if (typeof(T) == typeof(float))
            {
                Console.WriteLine($"Įvestis yra Type - Float");
            }
            else if (typeof(T) == typeof(double))
            {
                Console.WriteLine($"Įvestis yra Type - Double");
            }
            else if (typeof(T) == typeof(decimal))
            {
                Console.WriteLine($"Įvestis yra Type - Decimal");
            }
        }
    }
}
