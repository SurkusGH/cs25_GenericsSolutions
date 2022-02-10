using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions
{
    public class Solution_02
    {
        // Sukurkite klasę FourSideGeometricFigure

        // Properties:
        // - Name;
        // - Base;
        // - Height;

        public string Name { get; set; }
        public float Base { get; set; }
        public float Height { get; set; }

        public Solution_02(string name, float @base, float height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }
        // Funkcijos:
        // - GetArea();
        public void GetArea()
        {
            Console.WriteLine($"{Base} * {Height} = {Base * Height}");
        }

        // Taip pat overritinti funkciją ToString(), kad grąžintų aprašytą objektą.
        public override string ToString()
        {
            return $"Objekto {Name}, pagrindas yra {Base}, o aukštis {Height}.";
        }
    }
    public class Generator
    {
        // Tada sukurti Generator<T> klasę turinčią metodą Show, kuris atspausdins perduoto objekto ToString() grąžintą reikšmę.
        public void Show<T>(T printME)
        {
            Console.WriteLine(printME);
        }
    }
}
