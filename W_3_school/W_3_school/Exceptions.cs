using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using W_3_school;

namespace W_3_school
{
    class ThrowException : Exception
    {
        public ThrowException(string message) : base(message) { }
    }
  
    class Exceptions 
    {

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ThrowException("custom exception: age must be 18 or above..!");
            }
            else
            {
                Console.WriteLine("Access granted - you are old enough..!");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ValidateAge(16);
            }
            catch (ThrowException t)
            {
                Console.WriteLine("Caught Custom Exception:");
                Console.WriteLine(t.Message);
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
