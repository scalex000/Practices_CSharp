using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}!={1}", number, result);
            Console.ReadLine();
        }
    }
}
