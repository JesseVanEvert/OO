using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Team
    {
        Programmeur[] programmeurs = new Programmeur[4];
        int aantalProgrammeurs = 0;

        public void Addprogrammeur(Programmeur p)
        {
            programmeurs[aantalProgrammeurs] = p;
            aantalProgrammeurs++;
        }
        public void PrintTeam()
        {
            foreach(Programmeur programmeur in programmeurs)
            {
                programmeur.PrintProgrammeur();
                Console.WriteLine();
            }
        }
    }
}
