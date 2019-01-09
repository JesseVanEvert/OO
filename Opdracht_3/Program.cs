using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            team.Addprogrammeur(new Programmeur("Jan", (Specialiteit)0));
            team.Addprogrammeur(new Programmeur("Dirk", (Specialiteit)1));
            team.Addprogrammeur(new Programmeur("Henk", (Specialiteit)2));
            team.Addprogrammeur(new Programmeur("Piet", (Specialiteit)3));

            team.PrintTeam();

            Console.ReadKey();
        }
    }
}
