using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    /* --> If you don't want other classes to inherit from a class
     * The error message will be something like this:
     * 'Car': cannot derive from sealed type 'Vehicle'

     sealed class Vehicle // Base Class (Parent Class)
     {
         public string brand = "Ford"; // vehical field
         public void honk()
         {
             Console.WriteLine("Tuut, tuut!");
         }
     }
    */
    class Vehicle // Base Class (Parent Class)
    {
        public string brand = "Ford"; // vehical field
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle // Derived Class (Child)
    {
        public string modelName = "Endeavor"; // Car Field
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.honk();
            Console.WriteLine(c.brand + " " + c.modelName);
        }
    }
}
