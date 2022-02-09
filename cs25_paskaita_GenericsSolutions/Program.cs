using System;

namespace cs25_paskaita_GenericsSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs25_PASKAITA_GenericsSolutions!");

            Solution_01();
            Console.WriteLine();

            Solution_02();
            Console.WriteLine();

        }

        public static void Solution_01()
        {
            // Pirmas Solution:
            var solution = new Solution_01<string, decimal>(); // <-- jeigu neturėčiau tuščio ctor, čia turėčiau reikšmes nurodyt.
            solution.PrintTandF("Labas", 5m);                   //     Neskamba taisyklingai, nei be empty ctor, nei su juo. IDK. Google nepadeda. Bet veikia.

            solution.SetValueT("Viso gero");
            solution.SetValueF(10m);

            Console.WriteLine();

            solution.PrintTandF();
        }

        public static void Solution_02()
        {
            // Antras Solution:

            var solution2 = new Solution_02("Stačiakampis", 10, 5);
            Console.WriteLine(solution2); // <-- Šitą atliaka tiesiog overridinimas ToString;
            // Tada susikuriu generatoriuką, kuriam paduosiu stringą arg:
            var generator = new Generator<string>();
            generator.Show(solution2.ToString());
        }
    }
}

