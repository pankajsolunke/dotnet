using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    // To implement multiple interfaces, separate them with a comma( , )
    interface IFirst
    {
        void First();// interface method
    }
    interface ISecond
    {
        void Second(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirst , ISecond
    {
        public void First()
        {
            Console.WriteLine("First Interface...");
        }
        public void Second()
        {
            Console.WriteLine("Second Interface...");
        }
    }
    class MInterface
    {
        static void Main(string[] args)
        {
            DemoClass dc = new DemoClass();
            dc.First();
            dc.Second();
        }
    }
}
