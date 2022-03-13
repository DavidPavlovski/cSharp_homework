using System;

namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter first number : ");
            //bool input1 = decimal.TryParse(Console.ReadLine(), out decimal number1);
            //if (!input1)
            //{
            //    Console.WriteLine("Invalid input.Closing Application!");
            //    return;
            //}

            //Console.Write("Enter second number : ");
            //bool input2 = decimal.TryParse(Console.ReadLine(), out decimal number2);
            //if (!input2)
            //{
            //    Console.WriteLine("Invalid input.Closing Application!");
            //    return;
            //}

            //Console.Write("Enter third number : ");
            //bool input3 = decimal.TryParse(Console.ReadLine(), out decimal number3);
            //if (!input3)
            //{
            //    Console.WriteLine("Invalid input.Closing Application!");
            //    return;
            //}

            //Console.Write("Enter fourth number : ");
            //bool input4 = decimal.TryParse(Console.ReadLine(), out decimal number4);
            //if (!input4)
            //{
            //    Console.WriteLine("Invalid input.Closing Application!");
            //    return;
            //}

            Console.Write("Enter first number : ");
            string input1 = Console.ReadLine();
            bool output1 = decimal.TryParse(input1, out decimal number1);
            if (!output1)
            {
                Console.WriteLine($"Invalid input , {input1} is not a number.Closing Application");
                return;
            }

            Console.Write("Enter second number : ");
            string input2 = Console.ReadLine();
            bool output2 = decimal.TryParse(input2, out decimal number2);
            if (!output2)
            {
                Console.WriteLine($"Invalid input , {input2} is not a number.Closing Application");
                return;
            }

            Console.Write("Enter third number : ");
            string input3 = Console.ReadLine();
            bool output3 = decimal.TryParse(input3, out decimal number3);
            if (!output3)
            {
                Console.WriteLine($"Invalid input , {input3} is not a number.Closing Application");
                return;
            }

            Console.Write("Enter fourth number : ");
            string input4 = Console.ReadLine();
            bool output4 = decimal.TryParse(input4, out decimal number4);
            if (!output4)
            {
                Console.WriteLine($"Invalid input , {input4} is not a number.Closing Application");
                return;
            }

            decimal sum = number1 + number2 + number3 + number4;
            decimal average = sum / 4;

            Console.WriteLine($"The sum of {number1} + {number2} + {number3} + {number4} = {sum} \n the average is {sum}/4 = {average}");
        }
    }
}
