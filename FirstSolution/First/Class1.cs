using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace First
{
     class Class1
    {
        /*
         Constructor: 
         1.-> It's a special method present under a class
         responsible for initializing the variables of that class.

         2.-> The name of a constructor method is exactly
         the same name of the class in which it was present and 
         more over it's a non-value returning method.

         3.-> Each and every class requires this constructor if we
          want to create the instance of that class. 

         I.-> Implicitly defined constructor are public.
          
         4.-> Implicitly defined constructors are parameter less and these 
          constructors are also known as default constructors.

         II.-> Explicit constructor can be parameter less or parameterized also.
         */

        //int a, b;
        static void Main(string[] args)
        {
            Class1 f = new Class1 ();

            //Console.WriteLine("Value of a is: "+ f.a);
            //Console.WriteLine("Value of b is: "+ f.b);

            Console.ReadLine();
        }
    }
}
