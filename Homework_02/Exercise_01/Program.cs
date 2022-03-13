using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double decimalA = 2.5;
            double decimalB = 1.25;
            double decimalResult = decimalA / decimalB;
            Console.WriteLine(decimalA + " / " + decimalB + " = " + decimalResult);

            int intA = 4;
            int intB = 2;
            int intResult = intA / intB;
            Console.WriteLine(intA + " / " + intB + " = " + intResult);

            Console.WriteLine(decimalResult + " = " + intResult + " " + (decimalResult == intResult));
        }
    }
}
