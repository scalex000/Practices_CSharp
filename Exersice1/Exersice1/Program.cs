using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice1
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10");

            var EnterValue = Console.ReadLine();
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var isValid = false;
            foreach (var number in numbers)
            {
                if (EnterValue == number)
                {
                    isValid = true;
                }
            }
            if (isValid)
            {
                Console.WriteLine("Valid");
            }
            else Console.WriteLine("Invalid");
            Console.ReadLine();
        }
    }
}