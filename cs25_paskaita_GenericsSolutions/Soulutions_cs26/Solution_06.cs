using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions.Soulutions_cs26
{
    public class Solution_06 <Type>
    {
    // Sukurkite generic klasę su type T sąrašu viduje.
    public List<Type> List { get; set; }

        public Solution_06(List<Type> list)
        {
            List = list;
        }

        // Turi būti funkcijos:
        // Atspausdinti sąrašą
        public void PrintList()
        {
            List.ForEach(i => Console.WriteLine(i)); // <-- lambda?
            Console.WriteLine();
        }

        // Funkcija, kuri grąžina sąrašą konvertuotą į masyvą;
        public dynamic ConvertToArray()
        {
            var array = new Type[List.Count];
            //List.ToArray();
            List.CopyTo(array, 0);

            Console.WriteLine(array.GetType());
            return array.GetType();
        }

        // Funkcija, kuri prideda narį į sąrašą;
        public void AddToList(Type nameOfVariable)
        {
            List.Add(nameOfVariable);
        }

        // Funkcija, kuri prideda sąrašą narių į sąrašą;
        public void AddGroupToList(List<Type> nameOfList)
        {
            foreach (var item in nameOfList)
            {
                List.Add(item);
            }
        }

        // Funkcija, kuri ištrina elementą sąraše;
        public void RemoveElement(dynamic nameOfElement)
        {
            foreach (var item in List)
            {
                if (item == nameOfElement)
                {
                    List.Remove(item);
                }
            }
        }

        // Funkcija, kuri ištrina elementą sąraše pagal indeksą;
        public void RemoveElementByIndex(int index)
        {
            List.RemoveAt(index);
        }

        // Funkcija, kuri ištrina visus atitinkamus elementus sąraše(pvz.: ištrina visus dvejetus);
        public void RemoveAllElementsByValue(dynamic value)
        {
            List.RemoveAll(item => item == value);
        }
    }
}
