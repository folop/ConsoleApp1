using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dealer
    {
        public Balicek Ruka;
        public int HodnotaKaret;


        public Dealer()
        {
            Ruka = new Balicek();
        }
        public static void Schovat(Balicek pog) {
            int dolu = 1;
            
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
        public static void Ukazat(Balicek kocka) {
            Console.WriteLine("    ");
            Console.WriteLine("Dealerovi karty:");
            Console.WriteLine("    ");
            foreach (var kat in kocka)
            {
                Console.Write(kat.ID);
                Console.Write(kat.Barva);
                Console.Write("    ");


            }
            Console.WriteLine("    ");
        }
        public static void Lizak(Balicek dilerak, Balicek balicak, int hodnotak) {
            Console.WriteLine(hodnotak);
            while(hodnotak < 17) {
                dilerak.Push(balicak.Pop());
                Dealer.Ukazat(dilerak);
                Pravidylka.Hodi(dilerak, ref hodnotak);
                int mlem = hodnotak;
               
            }
        }
    }
}
