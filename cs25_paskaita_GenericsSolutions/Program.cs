using System;

namespace cs25_paskaita_GenericsSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs25_PASKAITA_GenericsSolutions!");

            var solution = new Solution_1<string , decimal>();
            solution.PrintTandF("Labas", 5m);

            solution.SetValueT("Viso gero");
            solution.SetValueF(10m);

            Console.WriteLine();

            solution.PrintTandF();

        }
    }
}

