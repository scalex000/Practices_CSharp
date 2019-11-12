using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var result = 0;
            var isExit = true;
            while (isExit)
            {
                Console.WriteLine("Enter a number or write 'ok' to Exit");
                var number = Console.ReadLine();
                if (number != "ok")
                {
                    result += Convert.ToInt32(number);
                }
                else isExit = false;
            }
            Console.WriteLine("The total is {0}", result);
            Console.ReadKey();
        }
    }
}
