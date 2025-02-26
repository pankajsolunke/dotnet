using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    abstract class Animals
    {
        public abstract void animalS();
       
       
        
        public void sleep()
        {
            Console.WriteLine("ZzZ");
        }

    }
    class Abstraction
    {
        public static void Main(string[] args)
        {
            // it is not possible to create an object of the Animal class
            // Cannot create an instance of the abstract class or interface
            // Animals a = new Animals();
        }

    }
}
