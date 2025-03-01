using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_3_school
{
    class Exceptions
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("age must be 18 or above..!");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ValidateAge(14);
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            finally
            {
                Console.WriteLine("first try-catch block finished\n");
            }
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[9]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went to wrong");
            }

            finally
            {
                Console.WriteLine("second try-catch block is finished.");
            }
            /*
            ✅ try → Code that may cause an exception.
            ✅ catch → Handles the exception.
            ✅ finally → Always executes(used for cleanup)
            */
        }
    }
}
