using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsExercises.ControlFlow
{
    class Loops
    {
        /*
         1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            Display the result on the console.
        */
        public void Exercise1()
        {
            int count = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.Write("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        /*
          2-  Write a program and continuously ask the user to enter a number. The loop terminates when the user 
              enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        */
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        /*
           3- Write a program which takes a single argument from the console, computes the factorial and prints the 
              value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
              and display it as 5! = 120.
        */
        public void Exercise3()
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        /*
           4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
              If the user guesses the number, display “You won". Otherwise, display “You lost".
         */
        public void Exercise4()
        {
            Console.WriteLine("Guess the secret number in 4 attempt: ");
            var number = new Random().Next(1, 10);
            Console.WriteLine("Secret number is: " + number);
            var attempt = 0;

            for (var i = 0; i < 4; i++)
            {
                attempt++;
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Attempt {0}", attempt);

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }

        /*
           5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
              numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
              display 8 on the console.
        */
        public void Exercise5()
        {
            Console.Write("Enter commoa separeted numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            //Assume the first numbers is Max
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is: " + max);
        }
    }
}
