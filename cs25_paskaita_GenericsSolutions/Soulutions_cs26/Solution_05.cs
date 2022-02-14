using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions.Soulutions_cs26
{
    public class Solution_05 <T>
    {
        // Sukurkite generic klasę su type T Read Only sąrašu(kintamieji priskiriami inicializuojant
        // ir jų keisti nebegalima). Sąrašas reikšmių inicializuoti sąrašui turi ateiti per konstruktorių.
        public List<T> List { get;  private set; }

        //public ReadOnlyCollection<T> ReadOnlyList => List.AsReadOnly(); // <-- ?

        public Solution_05(List<T> list)
        {
            List = list;
        }


        // Turi būti funkcijos:
        // Atspausdinti sąrašą;

        public void PrintMyList()
        {
            int indexer = 0;
            foreach (var item in List)
            {
                indexer++;
                Console.WriteLine($"Sarašo kintamasis #{indexer} -> {item}");
            }
            Console.WriteLine();
        }

        // Funkcija, kuri grąžina sąrašą konvertuotą į masyvą;
        public Array ConvertListToArray()
        {
            var array = new T[List.Count];
            List.ToArray(); 
            //List.CopyTo(array, 0);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Masyvo kintamasis #{i} -> {array[i]}");
            }
            Console.WriteLine();
            return array;
        }

        // Funkcija, kuri suranda ir grąžina VIENĄ atitkmenį sąraše.
        // Jeigu rado daugiau ar mažiau negu vieną turi mesti mesti klaidą;
        public dynamic FindInstanceInAList(dynamic instanceInList)
        {
            Solution_07.CheckIFInputIsNull(instanceInList);
            int counter = 0;
            foreach (var item in List)
            {
                if (instanceInList == item)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine($"Rastas {counter} instance įvesties {instanceInList}");
                Console.WriteLine();
            }
            else if (counter < 1)
            {
                Console.WriteLine($"(!) Klaida:");
                Console.WriteLine($"Rastas {counter} instance įvesties {instanceInList}");
                Console.WriteLine();
            }
            else if (counter > 1)
            {
                Console.WriteLine($"(!!!) Dar DISENSĖ klaida:");
                Console.WriteLine($"Rastas {counter} instance įvesties {instanceInList}");
                Console.WriteLine();
            }
            return instanceInList;
        }

        // Funkcija, kuri suranda ir grąžina vieną atitikmenį sąraše, BET jeigu jo neranda,
        // grąžina default’inę to duomenų tipo reikšmę.Jeigu randa daugiau NEGU 1 tada meta klaidą;

        public dynamic FindInstanceInAListTurbo(dynamic instanceInList)
        {
            Solution_07.CheckIFInputIsNull(instanceInList);
            int counter = 0;
            foreach (var item in List)
            {
                if (instanceInList == item)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"Rastas {counter} instance įvesties {instanceInList}");
                Console.WriteLine($"Gąžinama duomenų tipo reikšmė: {instanceInList.GetType()}");
                Console.WriteLine();
            }
            else if (counter > 1)
            {
                Console.WriteLine($"(!) Klaida:");
                Console.WriteLine($"Rastas {counter} instance įvesties {instanceInList}");
                Console.WriteLine();
            }
            
            return instanceInList.GetType();
        }

        // Funkcija kuri patikrina ar egzistuoja nurodytos reikšmės kintamasis sąraše ir grąžina bool tipo reikšmę atitinkančią paieškos rezultatą;
        public bool CheckType(dynamic instance)
        {
            Solution_07.CheckIFInputIsNull(instance);
            bool check;
            if (List[0].GetType() == instance.GetType())
            {
                check = true;
                Console.WriteLine($"Input type is same as List type");
                Console.WriteLine($"Returning bool value = {check}");
                Console.WriteLine();
            }
            else
            {
                check = false;
                Console.WriteLine($"Input type is not the same as List type");
                Console.WriteLine($"Returning bool value = {check}");
                Console.WriteLine();
            }
            return check;
        }
    }
}
