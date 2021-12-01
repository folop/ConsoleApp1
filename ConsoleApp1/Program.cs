using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ids = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "K", "Q" };
            string[] barvy = { "♥", "♦", "♣", "♠" };

            var hra = true;
            while (hra == true)
            {
                var menu = true;
                while (menu == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("0 - hrat");
                    Console.WriteLine("1 - zebricek");
                    Console.WriteLine("2 - pravidla");
                    Console.WriteLine("3 - o hre");
                    Console.WriteLine("4 - ukoncit");
                    Console.WriteLine("");

                    string volba = (Console.ReadLine());

                    if (volba == "0")
                    {
                        var i_nick = true;
                        while (i_nick == true) {
                            Console.WriteLine("zadej svuj nick");
                            string nick = Console.ReadLine();
                            if (nick.Length <= 2) {
                                Console.WriteLine("oops, moc kratke :c");
                                        
                            }else {
                                Hrac ten_co_hraje = new Hrac();
                                ten_co_hraje.Jmeno = nick;
                                ten_co_hraje.Penize = 1000;

                                var i_vklad = true;
                                while (i_vklad == true)
                                {
                                    Console.WriteLine("kolik chces vlozit?");

                                    try {
                                        string s_vklad = Console.ReadLine();
                                        int vklad = Convert.ToInt32(s_vklad);
                                        if (vklad >= ten_co_hraje.Penize)
                                        {
                                            Console.WriteLine("na to prece nemas penize :c");

                                        } else if (vklad <= 0)
                                        {
                                            Console.WriteLine("musis neco vsadit :c");

                                        }
                                        else {
                                            Console.WriteLine("frdf");
                                            Balicek pan_balicek = new Balicek();
                                            int hodnota;

                                            foreach (string barva in barvy)
                                            {

                                                foreach (string id in ids)
                                                {
                                                    hodnota = Int32.TryParse(id, out hodnota) ? hodnota : id == "A" ? 10 : 1;
                                                    pan_balicek.Push(new Karta(id, barva, hodnota));

                                                }
                                            }
                                            new Balicek(pan_balicek.OrderBy(karta => System.Guid.NewGuid()).ToArray());

                                        }

                                    }
                                    catch {
                                        Console.WriteLine("tohle prece neni cislo :c");
                                    }



                                    
                                    
                                }

                                




                            }
                        }

                    }
                    else if (volba == "1")
                    {
                        Console.WriteLine("zebricek");
                    }
                    else if (volba == "2")
                    {
                        Console.WriteLine("hrac na zacatku hry obdrzi dve karty a pak mu dealer nabizi dalsi");
                        Console.WriteLine("zakladni princip hry je, že hrac musi mit hodnotu vyssi nez dealer, ale nesmi prekrocit 21");
                        Console.WriteLine("karty od 2 do 10 maji stejnou hodnotu, jako je uvedena na karte");
                        Console.WriteLine("J, Q a K maji hodnotu 10");
                        Console.WriteLine("A muze mit hodnotu bud 11 nebo 1");
                        Console.WriteLine("barvy karet nemaji zadny vyznam");

                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine("Blackjack nebo také black jack je karetní hra často provozovaná v kasinu. Odlišná je především tím, že není jako většina hazardních her založena pouze na náhodě,");
                        Console.WriteLine("ale umožňuje pomocí různých strategií zvýšit pravděpodobnost výhry (především metoda tzv. počítání karet, kdy se hráč pokouší „zapamatovat“ tažené karty, má velkou publicitu). Blackjack se hraje s tzv. žolíkovými kartami.");
                        Console.WriteLine("Předchůdcem blackjacku je francouzská karetní hra vingt-et-un („dvacet jedna“), která se objevila ve francouzských kasinech kolem roku 1700.");
                        Console.WriteLine("Varianta této hry, téměř totožná po stránce pravidel (liší se vlastně pouze v terminologii a způsobu počítání), ale hraná s mariášovými kartami, se v českých zemích často hrála a hraje pod názvem jednadvacet či oko bere.");
                    }
                    else if (volba == "4")
                    {
                        menu = false;
                        hra = false;
                    }
                    else
                    {
                        Console.WriteLine("chybny input");
                    }
                    Console.WriteLine("");
                }

            }

        }





        
    }

}