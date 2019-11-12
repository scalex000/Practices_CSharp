using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var countNumber = 0;
            for (int i = 0; i < 100; i++)
            {
                var result = i % 3;
                if (result == 0)
                {
                    countNumber++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.",  countNumber);
            Console.ReadKey();
        }
    }
}
