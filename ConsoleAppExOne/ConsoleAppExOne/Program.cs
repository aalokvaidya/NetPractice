using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExOne
{
    class Program
    {
        public static List<Player> PlayerList()
        {
            List<Player> pList = new List<Player>()
            {
                new Player{ PlayerId = 1, PlayerTeam = "MI" },
                new Player{ PlayerId = 2, PlayerName = "Sam", PlayerTeam = "CSK" },
                new Player{ PlayerId = 3, PlayerName = "Gambhir", PlayerTeam = "KKR" }

            };
            return pList;
        }

        static void Main(string[] args)
        {
           
        }
    }
}
