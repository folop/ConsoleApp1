using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Pravidylka
    {
        public static string[] ids = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "K", "Q", "A" };
        public static string[] barvy = { "♥", "♦", "♣", "♠" };
        public static int hodnota;

        public static Balicek Existuj {
            get {
                Balicek pan_balicek = new Balicek();
                


                foreach (string barva in barvy)
                {

                    foreach (string id in ids)
                    {


                        
                        pan_balicek.Push(new Karta(id, barva));
                        



                    }
                }
                
                return pan_balicek;
            }
            
        }




        public static void Hodi(Balicek uwu, ref int mlem) {
            int hodnota = 0;
            foreach (var karta in uwu ) {
           
                if (karta.ID == "J")
                {
                    hodnota += 10;
                }
                else if (karta.ID == "Q")
                {
                    hodnota += 10;
                }
                else if (karta.ID == "K")
                {
                    hodnota += 10;
                }
                else if (karta.ID == "A")
                {
                    hodnota += 11;

                }
                else
                {
                    hodnota += Int32.Parse(karta.ID);
                }


            }
            
            
            mlem = hodnota;
        }
        public static void Acko (Balicek kontrola, int hodnotka) {
            foreach (var karta in kontrola) { 
                if (karta.ID == "A") {
                    if (hodnotka > 21) {
                        hodnotka -= 10;
                        
                    }
                }
            }
        }



        public static Balicek Mixatko { 
            get {
                return new Balicek(Existuj.OrderBy(karta => System.Guid.NewGuid()).ToArray());
            }
        }

        public static void DatKartu(Balicek haha, Balicek hoho) {
            haha.Push(hoho.Pop());
        }

        public static void Vyhodnoceni (int hhodnota, int dhodnota) {
        
            if (dhodnota == 21)
            {

                if (hhodnota == 21)
                {
                    
                    Console.WriteLine("remiza");
                }
                else
                {
                    
                    Console.WriteLine("prohra");

                }
            }
            else if (dhodnota > 21)
            {
                
                Console.WriteLine("prohra");

            }
            else if (hhodnota == 21) {
                
                Console.WriteLine("vyhra");
            } else if (hhodnota > dhodnota){
                
                Console.WriteLine("vyhra");
            } else if (hhodnota < dhodnota)
            {
                
                Console.WriteLine("prohra");
            }


        }


    }
}
