using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace ConsoleApp1
{
    class Hrac
    {
        public Balicek Ruka;

        public string Jmeno;
        public int Penize;

        public Hrac()
        {
            Ruka = new Balicek();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="balicek"></param>
        /// <returns></returns>
        public static double HodnotaVRuce (Balicek balicek)
        {
            int hod1 = balicek.Sum( c => c.Hodnota);

            double esa = balicek.Count(c => c.Barva == "A");
            double hod2 = esa > 0 ? hod1 + (10 * esa) : hod1;

            return new double[] { hod1, hod2 }
                .Select(HodnotaVRuce => new { HodnotaVRuce, vaha = Math.Abs(HodnotaVRuce - 21) + (HodnotaVRuce > 21 ? 100 : 0) })
                    .OrderBy(n => n.vaha)
                    .First().HodnotaVRuce;


        }
        
    }
}
