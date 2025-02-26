using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
   /*
      Static constructors are implicitly called whereas non-static
      constructors must be explicitly called.

   --> Non - Static constructors can be parameterized but 
       static constructors can't have any parameters.

   --> Non - Static constructors can be overloaded where as 
       static constructors can't be overloaded.
   */
     class Class4
    {
        static int a;
        int b;
        static Class4() // a staic constructor must be parameterless
        {
            Console.WriteLine("Static constructor is called.");
        }
        public Class4(int b)
        {
            this.b = b;
            Console.WriteLine("Non - Static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called");
            Class4 c1 = new Class4(24);
            Class4 c2 = new Class4(25);
            Class4 c3 = new Class4(26);
            Console.WriteLine(a);
            Console.WriteLine(c1.b+" "+c2.b+" "+c3.b);

            Console.ReadLine();
        }
    }
}
 