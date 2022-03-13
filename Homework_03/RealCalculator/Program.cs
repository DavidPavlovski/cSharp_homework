using System;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter first number : ");
            //bool input1 = decimal.TryParse(Console.ReadLine(), out decimal number1);
            //if (!input1)
            //{
            //    Console.WriteLine("Invalid input. Closing Application!");
            //    return;
            //}
            //Console.Write("Enter second number : ");
            //bool input2 = decimal.TryParse(Console.ReadLine(), out decimal number2);
            //if (!input2)
            //{
            //    Console.WriteLine("Invalid input. Closing Application!");
            //    return;
            //}


            Console.Write("Enter first number : ");
            string input1 = Console.ReadLine();
            bool output1 = decimal.TryParse(input1, out decimal number1);
            if (!output1)
            {
                Console.WriteLine($"Invalid input ,{input1} is not a number. Closing application!");
                return;
            }

            Console.Write("Enter second number : ");
            string input2 = Console.ReadLine();
            bool output2 = decimal.TryParse(input2, out decimal number2);
            if (!output2)
            {
                Console.WriteLine($"Invalid input ,{input2} is not a number. Closing application!");
                return;
            }

            Console.Write("Enter operation (+,-,*,/) : ");
            string operation = Console.ReadLine();

            decimal result;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"The result of {number1} + {number2} = {result}");
                    //Console.WriteLine($"The result of {number1} + {number2} = {number1 + number2}");
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"The result of {number1} - {number2} = {result}");
                    //Console.WriteLine($"The result of {number1} - {number2} = {number1 - number2}");
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"The result of {number1} * {number2} = {result}");
                    //Console.WriteLine($"The result of {number1} * {number2} = {number1 * number2}");
                    break;

                case "/":
                    result = number1 / number2;
                    Console.WriteLine($"The result of {number1} / {number2} = {result}");
                    //Console.WriteLine($"The result of {number1} / {number2} = {number1 / number2}");
                    break;

                default:
                    Console.WriteLine($"Invalid input. {operation} is not an operation!");
                    break;
            }
        }
    }
}
