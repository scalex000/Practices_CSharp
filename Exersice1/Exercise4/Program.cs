﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        /// <summary>
        ///  Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit :");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of a car :");
            var speedCar = Convert.ToInt32(Console.ReadLine());
            if(speedCar< speedLimit)
            {
                Console.WriteLine("Ok");
                Console.ReadKey();
            }
            else
            if(speedCar > speedLimit)
            {
                const int kmPerDemertPoint = 5;
                int aboveSpeed = (speedCar - speedLimit)/kmPerDemertPoint;
                if (aboveSpeed < 12)
                    Console.WriteLine("Demerit points: "+ aboveSpeed);
                else
                    Console.WriteLine("License Suspended");
                Console.ReadKey();

            }
        }
    }
}
