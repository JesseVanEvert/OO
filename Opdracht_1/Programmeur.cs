using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Programmeur
    {
        string naam;
        Specialiteit specialiteit;

        public Programmeur(string naam, Specialiteit specialiteit)
        {
            this.naam = naam;
            this.specialiteit = specialiteit;
        }
         
        public void PrintProgrammeur(Programmeur programmeur)
        {
            Console.WriteLine("Naam: " + programmeur.naam);
            Console.WriteLine("Specialiteit: " + programmeur.specialiteit);
        }
    }
}
