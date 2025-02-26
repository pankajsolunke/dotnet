using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
     class Class2
    {
        public int x = 100; // implicitly constructors 
    }
    class Class3
    {
        public int x;
        public Class3(int x) // Explicitly constructors pass the values
        {
            this.x = x;
        }
    }
    class TestClasses
    {
        static void Main()
        {
            Class2 f1 = new Class2();
            Class2 f2 = new Class2();
            Class2 f3 = new Class2();

            Console.WriteLine(f1.x +" "+ f2.x +" "+ f3.x); 

            Class3 c1 = new Class3(2);
            Class3 c2 = new Class3(12);
            Class3 c3 = new Class3(22);

            Console.WriteLine(c1.x + " " + c2.x + " " + c3.x);

        }
    }
}
