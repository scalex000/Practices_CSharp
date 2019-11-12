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
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landspace : ImageOrientation.Portrait;
            Console.WriteLine("Image orintation is "+orientation);
            Console.ReadLine();
        }
        public enum ImageOrientation
        {
            Landspace,
            Portrait
        }
    }
}
