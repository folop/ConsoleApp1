using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace ConsoleApp1
{
    class Hrac
    {
        public Balicek Ruka;
        public int HodnotaKaret;
        public string Jmeno;
        public int Penize;

        public Hrac()
        {
            Ruka = new Balicek();
        }
        public static void DrziKarty( Balicek pomoc) {
            Console.WriteLine("    ");
            Console.WriteLine("Tvoje karty:");
            Console.WriteLine("    ");
            foreach (var kat in pomoc)
            {
                Console.Write(kat.ID);
                Console.Write(kat.Barva);
                Console.Write("    ");


            }
            Console.WriteLine("    ");
        }


    }
}
