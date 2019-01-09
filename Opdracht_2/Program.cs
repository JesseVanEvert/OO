using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            Console.Write("Voer een naam in: ");
            string naam = Console.ReadLine();
            Console.Write("Voer een specialiteit in: ");
            string inputSpec = Console.ReadLine();
            Enum.TryParse(inputSpec, out Specialiteit specialiteit);

            Programmeur programmeur1 = new Programmeur(naam, specialiteit);
            programmeur1.PrintProgrammeur();
           */

            Team team = new Team();
            team.PrintTeam();

            Console.ReadKey();
        }
    }
}
