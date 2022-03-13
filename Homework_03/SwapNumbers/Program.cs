using System;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number : ");
            string input1 = Console.ReadLine();
            bool output1 = int.TryParse(input1, out int number1);
            if (!output1)
            {
                Console.WriteLine($"Invalid input , {input1} is not a number. Closing Application.");
                return;
            }

            Console.Write("Enter second number : ");
            string input2 = Console.ReadLine();
            bool output2 = int.TryParse(input2, out int number2);
            if (!output2)
            {
                Console.WriteLine($"Invalid input , {input2} is not a number. Closing Application.");
                return;
            }
            Console.WriteLine($"\n The first number is {number1} \n The second number is {number2}");

            Console.WriteLine("\n Swapping numbers \n");
            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"After swapping the first number is {number1} \n The second number is {number2}");

            //*************************************************************

            //Console.Write("Enter first value : ");
            //string input1 = Console.ReadLine();

            //Console.Write("Enter second value : ");
            //string input2 = Console.ReadLine();

            //Console.WriteLine($"The first value is {input1} \n The second value is {input2}");

            //Console.WriteLine("Swapping values");
            //string temp = input1;
            //input1 = input2;
            //input2 = temp;
            //Console.WriteLine($"After swapping , the first value is {input1} \n the second value is {input2}");

            //*************************************************************

            //Console.Write("Enter first number : ");
            //bool input1 = int.TryParse(Console.ReadLine(), out int number1);

            //if (!input1)
            //{
            //    Console.WriteLine("Invalid input. Closing application.");
            //    return;
            //}

            //Console.Write("Enter second number : ");
            //bool input2 = int.TryParse(Console.ReadLine(), out int number2);

            //if (!input2)
            //{
            //    Console.WriteLine("Invalid input. Closing application.");
            //    return;
            //}
            //Console.WriteLine($"\n The first number is {number1} \n The second number is {number2}");

            //Console.WriteLine("\n Swapping numbers \n");

            //int temp = number1;
            //number1 = number2;
            //number2 = temp;
            //**(number1, number2) = (number2, number1)**; 
            //Console.WriteLine($"After swapping the first number is {number1} \n The second number is {number2}");


        }
    }
}
