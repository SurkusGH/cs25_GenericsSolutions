using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions
{
    public class Solution_01<T, F>
    {
        // Generics parametrų galima naudoti daugiau negu vieną pvz Method<T1, T2>
        // Sukurkite klasę kuri priima du generic tipo parametrus.
        // Klasė turės du kintamuosius kurie atitiks tuos generic parametrus.

        public T ValueT { get; set; }
        public F ValueF { get; set; }

        public Solution_01(T valueT, F valueF)
        {
            ValueT = valueT;
            ValueF = valueF;
        }

        public Solution_01()
        {
        }

        // Turės keturias funkcijas, dvi iš jų bus atspausdinti T1 ir T2 properties

        //public void PrintTandF(T input1, F input2)
        //{
        //    Console.WriteLine($"Pirmasis kintamasis: {input1}, jo tipas yra {input1.GetType()} tipo");
        //    Console.WriteLine($"Antrasis kintamasis: {input2}, jo tipas yra {input2.GetType()} tipo");
        //}
        public void PrintTandF(T input1, F input2) // <-- Sekančio metodo užduotyje, kaip ir nebuvo... arba šito metodo nebuvo.
        {
            Console.WriteLine($"Pirmasis kintamasis: {input1}, jis yra {input1.GetType()} tipo");
            Console.WriteLine($"Antrasis kintamasis: {input2}, jis yra {input2.GetType()} tipo");
        }
        public void PrintTandF() // ^-- Ankstesnis metodas atlieka iš esmės visas tris žemesnes funkcijas vienas. Idk.
        {
            Console.WriteLine($"Pirmasis kintamasis: {ValueT}, jis yra {ValueT.GetType()} tipo");
            Console.WriteLine($"Antrasis kintamasis: {ValueF}, jis yra {ValueF.GetType()} tipo");
        }

        // Kitos dvi funkcijos leis pakeisti reikšmę T1 ir T2 properties.

        public T SetValueT(T input)
        {
            ValueT = input;
            Console.WriteLine($"Naujas T value yra {ValueT}");
            return ValueT;

        }

        public F SetValueF(F input)
        {
            ValueF = input;
            Console.WriteLine($"Naujas F value yra {ValueF}");
            return ValueF;

        }
    }
}
