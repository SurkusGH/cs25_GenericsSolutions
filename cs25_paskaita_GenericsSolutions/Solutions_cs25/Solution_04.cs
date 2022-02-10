using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_paskaita_GenericsSolutions.Solutions
{
    public class Solution_04<T>
    {
        // Create a generic class to implement a league table for a sport.
        // The class should allow teams to be added to the list, and store
        // a list of teams that belong to the league.
        public List<T> TeamList { get; set; }

        public Solution_04(List<T> teamList)
        {
            TeamList = teamList;
        }

        // Your class should have a method to print out the teams in order,
        // with the team at the top of the league printed first.

        public void TeamListPrintOut()
        {
            foreach (var item in TeamList)
            {
                Console.WriteLine(item); // <-- Čia reikia overridinti
            }
        }
        // Only teams of the same type should be added to any particular
        // instance of the league class - the program should fail to compile
        // if an attempt is made to add an incompatible team.
        //public bool AddTeamTypeA(T Team)
        //{
        //    if (Team.Contains("TypeA"))
        //    {
        //        TeamList.Add(Team);
        //    }
        //}
    }

    public class TeamTypeA
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public TeamTypeA(string name, string type = "TypeA", int level = 0)
        {
            Name = name;
            Type = type;
            Level = level;
        }
    }

    public class TeamTypeB
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public TeamTypeB(string name, string type = "TypeB", int level = 0)
        {
            Name = name;
            Type = type;
            Level = level;
        }
    }
}
