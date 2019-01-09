using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
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

        public void PrintProgrammeur()
        {
            Console.WriteLine("Naam: " + this.naam);
            Console.WriteLine("Specialiteit: " + this.specialiteit);
        }
    }
}
