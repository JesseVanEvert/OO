using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Boekhandel
    {
        protected List<Boek> Bladen { get; set; }
        protected float TotalePrijs
        {
            get
            {
               float totaleprijs = 0;
               foreach(Boek blad in Bladen)
                {
                  totaleprijs +=  blad.Prijs * blad.Aantal;
                }
                return totaleprijs;
            }            
        }

        public void VoegToe(Boek boek)
        {
            Bladen.Add(boek);
        }
        public void WijzigVoorraad(Boek boek)
        {
            Console.Write("Voeg toe aan voorraad: ");
            int hoeveelheid = int.Parse(Console.ReadLine());
            boek.Aantal += hoeveelheid;
            Console.WriteLine(boek.Aantal.ToString());
        }
    }
}
