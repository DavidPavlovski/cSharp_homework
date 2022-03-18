using System;

namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter number {i + 1} : ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine($"{input} is not a valid integer. Please try again.");
                        continue;
                    }
                    numbers[i] = number;

                    break;
                }
            }

            while (true)
            {
                Console.Write("Would you like to an additional number (y / any)? ");
                string addMore = Console.ReadLine();
                if (addMore.ToLower() != "y") // ->  if (addMore !="y" && addMore != "Y")
                {
                    Console.WriteLine("Calculating results");
                    break;
                }

                while (true)
                {
                    Console.Write($"Enter number {numbers.Length + 1} : ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine($"{input} is not a valid integer. Please try again.");
                        continue;
                    }
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number;
                    break;
                }
            }

            Console.WriteLine("You have entered : ");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
                Console.Write(number + " ");
            }

            Console.WriteLine($"\nThe sum of odd numbers is : {oddSum}");
            Console.WriteLine($"The sum of even numbers is : {evenSum}");
        }
    }
}
