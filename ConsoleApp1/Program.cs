using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public Balicek Existuj;
        static void Main(string[] args)
        {
            
            var i_nick = true;
            var i_vklad = true;
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
                        
                        while (i_nick == true) {
                            Console.WriteLine("zadej svuj nick");
                            string nick = Console.ReadLine();
                            if (nick.Length <= 2) {
                                Console.WriteLine("oops, moc kratke :c");
                                        
                            }else {
                                Dealer pan_pog = new Dealer();
                                Hrac ten_co_hraje = new Hrac();
                                ten_co_hraje.Jmeno = nick;
                                ten_co_hraje.Penize = 1000;

                                
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
                                            //Pravidylka.Hodi(Pravidylka.Existuj);
                                            //Pravidylka.Hodi(Pravidylka.Mixatko);

                                            ten_co_hraje.Ruka.Clear();
                                            pan_pog.Ruka.Clear();

                                            ten_co_hraje.HodnotaKaret = 0;
                                            pan_pog.HodnotaKaret = 0;

                                            Pravidylka.DatKartu(ten_co_hraje.Ruka, Pravidylka.Mixatko);
                                            Pravidylka.DatKartu(pan_pog.Ruka, Pravidylka.Mixatko);
                                            Pravidylka.DatKartu(ten_co_hraje.Ruka, Pravidylka.Mixatko);
                                            Pravidylka.DatKartu(pan_pog.Ruka, Pravidylka.Mixatko);
                                            Dealer.Schovat(pan_pog.Ruka);
                                            Hrac.DrziKarty(ten_co_hraje.Ruka);

                                            
                                            Pravidylka.Hodi(ten_co_hraje.Ruka, ref ten_co_hraje.HodnotaKaret);
                                            int mlem = ten_co_hraje.HodnotaKaret;
                                            Console.WriteLine(ten_co_hraje.HodnotaKaret);

                                            Pravidylka.Hodi(pan_pog.Ruka, ref pan_pog.HodnotaKaret);
                                            mlem = pan_pog.HodnotaKaret;
                                            Console.WriteLine(pan_pog.HodnotaKaret);







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