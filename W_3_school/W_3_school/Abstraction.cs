using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    // Abstract class
    abstract class Animals
    {
        // Abstract method (does not have a body)
        public abstract void animalS();

        // Regular Method
        public void sleep()
        {
            Console.WriteLine("good night ZzZ");
        }

    }

    //Derived Class (Inherit from Animals)
    class Cat : Animals
    {
        public override void animalS()
        {
            //The Body of animalS is provided here
            Console.WriteLine("The cat says: meow meow");
        }
    }
    class Abstraction
    {
        public static void Main(string[] args)
        {
            // it is not possible to create an object of the Animal class
            // Cannot create an instance of the abstract class or interface
            // Animals a = new Animals();

            Cat c = new Cat(); // Create a cat object
            c.animalS();  // Call the Abstract method
            c.sleep();   // Call the Regular method
        }

    }
}
