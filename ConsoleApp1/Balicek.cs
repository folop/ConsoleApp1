using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Balicek : Stack<Karta>
    {
        public Balicek(IEnumerable<Karta> collection) : base(collection) { }
        public Balicek() : base(52) { }
    }
    
}
