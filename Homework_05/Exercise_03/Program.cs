using System;

namespace Exercise_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello from SEDC Codeacademy 2022";
            Console.WriteLine($"The message is : \"{message}\" with a length of {message.Length}");
            while (true)
            {
                Console.Write($"Enter a number between 0 and {message.Length} : ");
                if (!int.TryParse(Console.ReadLine(), out int index))
                {
                    Console.WriteLine("Input must be a valid integer! Try again.");
                    continue;
                }
                else if (index > message.Length || index < 0)
                {
                    Console.WriteLine($"The input number must be between 0 and {message.Length}");
                    continue;
                }
                Substring(message, index);
                break;
            }
        }
        public static void Substring(string message, int subIndex)
        {
            string subMessage = message.Substring(0, subIndex);
            Console.WriteLine($"New message : \"{subMessage}\" with a  length of {subMessage.Length}");
        }
    }
}