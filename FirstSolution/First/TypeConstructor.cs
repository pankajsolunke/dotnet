using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    /*Type of Constructors
     * 1.Default or parameter less Constructor
     * 2.Parameterized Constructor
     * 3.Copy Constructor
     * 4.Static Constructor
     * 
     * If a constructor method doesn't take any parameters then 
     * we call that as default or parameter less. 
     * These constructors can be defined by a programmer explicitly or else
     * will be default implicitly provided there is no explicit constructor
     * under the class.
     * 
     * 2. Parameterized Constructor:
     *  If a constructor method is defined with out any parameters 
     *  we call that as parameterized constructor and these constructors
     *  can be defind by the programmers only but never can be defined implicitly.
     * 
     * 
     * 
     */
    class TypeConstructor
    {
        /*Default or parameter less Constructor
        public TypeConstructor() { 
        
        }
        */

        /*Parameterized Constructor
        int x;
         public TypeConstructor(int i) {
            x = i;
            Console.WriteLine("Parameterized Constructor is called:"+i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is: " + x);
        }
        */

        /*Copy Constructor:
          It we want to create multiple instances with the same values
          then we use these copy constructors, in a copy constructor the
          constructor takes the same class as a paramter to it.
         */

        int x;
        public TypeConstructor(int i) {
            x = i;
        }
        public TypeConstructor(TypeConstructor obj)
        {
            x = obj.x;
        }
        public void Display()
        {
           Console.WriteLine("Value of x is: "+x);
        }
        static void Main(string[] args)
        {
            TypeConstructor t = new TypeConstructor(10);
            TypeConstructor t1 = new TypeConstructor(t);
            t.Display();
            t1.Display();

            Console.ReadLine();


            //TypeConstructor t = new TypeConstructor(23);
            //TypeConstructor t1 = new TypeConstructor(12);
            //t.Display();
            //t1.Display();
            //Console.ReadLine();
        }
        


    }
}
