using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Boek
    {
       protected string Titel { get; set; }
       public float Prijs { get; set; }
       public int Aantal { get; set; }

        public Boek(string titel, float prijs, int aantal)
        {
            this.Titel = titel;
            this.Prijs = prijs;
            this.Aantal = aantal;
        }
        public virtual string Print()
        {
            return "Titel: " + Titel + " Prijs: " + Prijs + " Aantal: " + Aantal;
        }
        public void Wijzigvoorraad()
        {

        }
    }
}
