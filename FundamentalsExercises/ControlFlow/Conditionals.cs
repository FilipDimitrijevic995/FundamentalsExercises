using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsExercises.ControlFlow
{
    class Conditionals
    {

        /*
        1- Write a program and ask the user to enter a number.
           The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
           Otherwise, display "Invalid". (This logic is used a lot in applications where values entered 
           into input boxes need to be validated.)
        */
        public void Exercise1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


        /*
         2- Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        public void Exercise2()
        {
            Console.Write("Enter a first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Maximum is: " + max);
        }

        /*
        3- Write a program and ask the user to enter the width and height of an image. 
           Then tell if the image is landscape or portrait. 
        */
        public void Exercise3()
        {
            Console.Write("Please enter a width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Orientation is: " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        /*
        4- Your job is to write a program for a speed camera.
           For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
           Write a program that asks the user to enter the speed limit.
           Once set, the program asks for the speed of a car. 
           If the user enters a value less than the speed limit, program should display Ok on the console.
           If the value is above the speed limit, the program should calculate the number of demerit points.
           For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
           If the number of demerit points is above 12, the program should display License Suspended.
        */
        public void Exercise4()
        {
            Console.Write("Enter the speed limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a car speed: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License suspended!!!");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
            }
        }

    }
}
