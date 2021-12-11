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
                    if (hodnota + 11 >21) {
                        hodnota += 1;
                    } else {
                        hodnota += 11;
                    }

                }
                else
                {
                    hodnota += Int32.Parse(karta.ID);
                }


            }
            
            
            mlem = hodnota;
        }




        public static Balicek Mixatko { 
            get {
                return new Balicek(Existuj.OrderBy(karta => System.Guid.NewGuid()).ToArray());
            }
        }

        public static void DatKartu(Balicek haha, Balicek hoho) {
            haha.Push(hoho.Pop());
        }

       

}
}
