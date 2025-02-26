using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Reference
{
   class First
    {
        /* 
Variable of a class: a copy of the class that is not initialized.

Instance of a class: a copy of the class that is initialized by using the new keyword. 
         
Reference of a class: a copy of the class that is initialized by using an existing instance.
Reference of a class can be called as a pointer to the instance
Class : It's a user-defined type
        */
        int x = 20;
        static void Main(string[] args)
        {
            //First f = new First();--> f is the instance of class

            //First f;--> f is vsriable of class
            //f = new First();--> f is instance of class

            //First f1 = new First();
            //First f2 = new First();
            //Console.WriteLine(f1.x);
            //Console.WriteLine(f2.x);
            //f1.x = 1000;
            //Console.WriteLine(f1.x);
            //f2.x = 2000;
            //Console.WriteLine(f2.x);

            First f = new First();
            First f2 = f;// f2 is reference of the class

            //string firstn = "pankaj";
            //string lastn = "deshmukh";
            //string fulln = $"my full name is: {firstn}  {lastn}";
            //Console.WriteLine(fulln);

            // Full name
            //string name = "John Doe";

            //// Location of the letter D
            //int charPos = name.IndexOf("D");

            //// Get last name
            //string lastName = name.Substring(charPos);

            //// Print the result
            //Console.WriteLine(lastName);

            int[,] a = { { 31, 32, 33 }, { 24, 25, 26 } };

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
            }
        }
    }
}
