using System;
using System.Collections.Generic;

namespace Homework_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            while (true)
            {
                Console.Write("Enter a number : ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Input is not a number");
                    Console.ReadLine();
                    continue;
                }
                numbers.Enqueue(number);
                Console.WriteLine("Would you like to enter a different number (y/n) ? ");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    break;
                }
                continue;
            }

            while (numbers.TryDequeue(out int number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
