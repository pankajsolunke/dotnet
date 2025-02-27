using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    enum Friend
    {
        //by default, the first item of an enum has the value 0.
        //The second has the value 1
        abhishek, //0
        nitin, //1
        vishal //2
    }
    class Enums
    {
        // enum is a special class that represents a group of constants (unchangeable / read-only variables)
        enum Job
        {
            //You can also assign your own enum values
//and the next items will update their numbers accordingly
            devops_eng, //0
            mr = 5, //5
            salesforce_dev //6
        }

        static void Main(string[] args)
        {
            Friend f = Friend.abhishek;
            Job j = Job.devops_eng;

            Friend f1 = Friend.nitin;
            Job j1 = Job.mr;

            int f2 = (int) Friend.vishal;
            int ji1 = (int)Job.mr;
            
            Console.Write(f+" ");
            Console.WriteLine(j);
            Console.Write(f1+" ");
            Console.WriteLine(j1);
            Console.WriteLine(f2);
            Console.WriteLine(ji1);

//            Enum in a Switch Statement
            switch (f)
            {
                case Friend.abhishek:
                    Console.WriteLine("abhiskek deshmuke");
                    break;
                case Friend.nitin:
                    Console.WriteLine("nitin nana deshmuke");
                    break;
                case Friend.vishal:
                    Console.WriteLine("vishal patil");
                    break;
            }



        }
    }
}
