using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boek boek = new Boek("Sapiens", 20, 30);
            Boek boek2 = new Boek("Homo deus", 20, 30);
            Boek boek3 = new Boek("Mythos", 15, 10);
            Tijdschrift tijdschrift = new Tijdschrift("Historia", 7.50f, 100, new DateTime(2008, 5, 1));
            Console.WriteLine(boek.Print());
            Console.WriteLine(tijdschrift.Print());           
            Boekhandel boekhandel = new Boekhandel();
            boekhandel.WijzigVoorraad(boek);
            Console.ReadKey();
        }
    }
}
