using cs25_paskaita_GenericsSolutions.Solutions;
using cs25_paskaita_GenericsSolutions.Soulutions_cs26;
using System;
using System.Collections.Generic;

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

            Solution_03();
            Console.WriteLine();

            Solution_04();
            Console.WriteLine();

            // Solutions_cs26

            Solution_05();
            Console.WriteLine();

            Solution_06();
            Console.WriteLine();

            Solution_07();
            Console.WriteLine();
        }
        #region Solutions_cs25
        public static void Solution_01()
        {
            Console.WriteLine("Solution_01");
            var solution = new Solution_01<string, decimal>(); // <-- jeigu neturėčiau tuščio ctor, čia turėčiau reikšmes nurodyt.
            solution.PrintTandF("Labas", 5m);                   //     Neskamba taisyklingai, nei be empty ctor, nei su juo. IDK. Google nepadeda. Bet veikia.

            solution.SetValueT("Viso gero");
            solution.SetValueF(10m);

            Console.WriteLine();

            solution.PrintTandF();
        }
        public static void Solution_02()
        {
            Console.WriteLine("Solution_02");
            var solution2 = new Solution_02("Stačiakampis", 10f, 5f);
            Console.WriteLine(solution2); // <-- Šitą atliaka tiesiog overridinimas ToString();
            // Tada susikuriu generatoriuką, kuriam paduosiu stringą arg:
            var generator = new Generator();
            generator.Show(solution2);
        }
        public static void Solution_03()
        {
            Console.WriteLine("Solution_03");
            var solution3a = new Solution_03<int>(10, 5);
            solution3a.ValueAddition();
            var solution3b = new Solution_03<float>(10f, 5f);
            solution3b.ValueSubstraction();
            var solution3c = new Solution_03<double>(10d, 5d);
            solution3c.ValueMultiplication();
            var solution3d = new Solution_03<decimal>(10m, 5m);
            solution3d.ValueSubstraction();

        }
        public static void Solution_04()
        {
            Console.WriteLine("Solution_04");
        }
        #endregion

        #region Solutions_cs26
        public static void Solution_05()
        {
            Console.WriteLine("Solution_05");
            var list = new List<string>();
            list.Add("Aš");
            list.Add("Aš");
            list.Add("Tu");
            list.Add("Mes");
            list.Add("Jie");
            var solution5 = new Solution_05<string>(list);
            solution5.PrintMyList();

            solution5.ConvertListToArray();

            solution5.FindInstanceInAList("Tu");
            solution5.FindInstanceInAList("Jos");
            solution5.FindInstanceInAList("Aš");

            solution5.FindInstanceInAListTurbo("Tu");
            solution5.FindInstanceInAListTurbo("Jos");
            solution5.FindInstanceInAListTurbo("Aš");

            solution5.CheckType(1f);
            solution5.CheckType(1d);
            solution5.CheckType("String");


        }

        public static void Solution_06()
        {
            Console.WriteLine("Solution_05");
        }

        public static void Solution_07()
        {
            Console.WriteLine("Solution_05");
        }

        #endregion
    }
}

