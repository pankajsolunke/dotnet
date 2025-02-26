using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    class Animal // Bass class (parent class)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal // Derive class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal // Derived class (child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says: bow wow");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal p = new Pig();
            Animal d = new Dog();

            a.animalSound();
            p.animalSound();
            d.animalSound();

        }

    }
}
