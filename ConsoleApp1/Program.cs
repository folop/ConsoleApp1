using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Karta { 
        public string ID { get; set; }
        public string Barva { get; set; }
        public int Hodnota { get; set; }

        public Karta(string id, string barva, int hodnota) {
            ID = id;
            Barva = barva;
            Hodnota = hodnota;
        }
    }

    public class Balicek : Stack<Karta> {
        public Balicek(IEnumerable<Karta> collection) : base(collection) { }
        public Balicek() : base(52) { }

    }

    public class Hrac {
        Balicek Ruka;

        public Hrac() {
            Ruka = new Balicek();
        }
    }

    public static class pravuwudla
    {
        public static string[] ids = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "K", "Q" };
        public static string[] barvy = { "♥", "♦", "♣", "♠" };

        public static Balicek Novy { 
            get {
                Balicek b = new Balicek();
                int hodnota;

                foreach (string barva in barvy) {
                    
                    foreach(string id in ids) {
                        hodnota = Int32.TryParse(id, out hodnota) ? hodnota : id == "A" ? 1 : 10;
                        b.Push(new Karta(id, barva, hodnota));
                    }
                }
                return b;
            }
        }


        public static Balicek Zamichat
        {
        
            get{
                return new Balicek(Novy.OrderBy(karta => System.Guid.NewGuid()).ToArray());
            }
        }

        


    }


}
