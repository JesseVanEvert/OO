using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Tijdschrift : Boek
    {
        protected DateTime Uitgifte { get; set; }
        public Tijdschrift(string titel, float prijs, int aantal, DateTime uitgifte) : base(titel, prijs, aantal)
        {
            this.Uitgifte = uitgifte;
        }

        public override string Print()
        {
            return "Titel: " + Titel + " Prijs: " + Prijs + " Aantal: " + Aantal + " Uitgifte: " + Uitgifte;
        }
    }
}
