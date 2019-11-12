using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Write a program which takes two numbers from the console and displays the maximum of the two.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine();

            Console.WriteLine("Max is " +max.ToString());
            Console.ReadLine();
        }
    }
}
