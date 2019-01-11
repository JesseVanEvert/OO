using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class CD : Boek
    {
        public string Artiest { get; set; }
        public CD(string titel, float prijs, int aantal, string artiest) : base(titel, prijs, aantal)
        {
            this.Artiest = artiest;
        }
    }
}
