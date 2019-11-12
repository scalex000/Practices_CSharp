using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int chances = 4;
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            int guesser;
            int chance = 0;

            do
            {
                Console.WriteLine("Enter a number to win, Chances {0}", chances - chance);
                guesser = Convert.ToInt32(Console.ReadLine());
                chance++;
            } while ((randomNumber == guesser) || (chance < chances));

            if (randomNumber == guesser)
            {
                Console.WriteLine("You won");
            }
            else Console.WriteLine("You lost. The number is {0}", randomNumber);
            Console.ReadKey();
        }
    }
}
