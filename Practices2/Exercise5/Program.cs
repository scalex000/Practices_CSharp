using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a serie of number separated by comma. eg. 1,2,3..");
            var commaNumber = Console.ReadLine();
            var numberLists = commaNumber.Split(',').Select(Int32.Parse).ToList();
            var maxNumber = numberLists.Max();
            Console.WriteLine("The max number of the serie is {0}", maxNumber);
            Console.ReadKey();
                            

        }
    }
}
