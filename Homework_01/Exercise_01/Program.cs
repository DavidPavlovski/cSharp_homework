using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows(input must be a valid number) : ");
            string userInput = Console.ReadLine();
            try
            {
                int rows = int.Parse(userInput);
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 0; j < rows - i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot parse input as a number for value : " + userInput);
            }
        }
    }
}
