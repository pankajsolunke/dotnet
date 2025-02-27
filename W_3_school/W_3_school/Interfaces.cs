using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W_3_school
{
    // Interfaces can contain properties and methods, but not fields/variables
    interface IA
    {
        // Property (only declaration, no backing field)
        string Name { get; set; }
        // Method declaration (no body)
        void animalSound(); // Interface Method (does not have a body)
    }

    // P implementing the IA interface
    class P : IA
    {
        // Implementing the Property
        public string Name { get; set; }
        //On implementation of an interface, you must override all of its methods
        public void animalSound()
        {
            // The body of animal Sound is provided here
            Console.WriteLine("The pig says: wee wee");
        }
        
    }
    class Interfaces
    {
       static void Main(string[] args)
        {
            IA i = new P { Name = "Moti" };
            P p = new P { Name = "Buddy"}; // Create a P class object
            p.animalSound();

            Console.WriteLine($"my dogs name is {i.Name}");
            Console.WriteLine($"my dog's name is {p.Name} ");

            //it is not possible to create an "IA" object in the Interface class
            //IA a = new IA();
        }
    }
}
