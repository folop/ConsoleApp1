using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dealer
    {
        public Balicek Ruka;

      

        public Dealer()
        {
            Ruka = new Balicek();
        }
        public static void Schovat(Balicek pog) {
            int dolu = 1;
            Console.WriteLine("    ");
            Console.WriteLine("Dealerovi karty:");
            Console.WriteLine("    ");
            foreach (var kat in pog)
            {
                if (dolu == 1)
                {
                    Console.Write(kat.ID);
                    Console.Write(kat.Barva);
                    Console.Write("    ");

                    dolu = +2;


                }
                else
                {
                    Console.Write("[?]");
                    Console.WriteLine("    ");
                }
            }
            Console.WriteLine("    ");
        }
    }
}
