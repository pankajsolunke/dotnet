using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    class Person
    {
        //private string name; // field

        public string Name   // property
        {
            //get { return name; }   // get method
            //set { name = value; }  // set method
            get; set;
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
             Person p = new Person();
            p.Name = "Pankaj Deshmukh";
            Console.WriteLine(p.Name);
        }
    }
}
