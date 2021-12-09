using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Karta
    {
        public string ID { get; set; }
        public string Barva { get; set; }
        

        public Karta(string id, string barva)
        {
            ID = id;
            Barva = barva;
            
        }
    }
}
