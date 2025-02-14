using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Explicit
    {
        public Explicit() {

            Console.WriteLine("Constructor is called.");
        }
        static void Main(string[] args)
        {
            Explicit e = new Explicit();
            Explicit e1 = new Explicit();
            Explicit e2= new Explicit();
            Console.ReadLine();
        }
    }
}
