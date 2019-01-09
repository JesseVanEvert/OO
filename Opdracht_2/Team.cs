using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Team
    {
        Programmeur p1 = new Programmeur("Jan", (Specialiteit)0);
        Programmeur p2 = new Programmeur("Dirk", (Specialiteit)1);
        Programmeur p3 = new Programmeur("Henk", (Specialiteit)2);
        Programmeur p4 = new Programmeur("Piet", (Specialiteit)3);

        List<Programmeur> programmeurs = new List<Programmeur>();


        public void PrintTeam()
        {
            programmeurs.Add(p1);
            programmeurs.Add(p2);
            programmeurs.Add(p3);
            programmeurs.Add(p4);

            foreach(Programmeur programmeur in programmeurs)
            {
                programmeur.PrintProgrammeur();
                Console.WriteLine();
            }
        }
    }
}
