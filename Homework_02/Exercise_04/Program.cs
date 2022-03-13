using System;

namespace Exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine($"With your current credit balance of {n}, you can send {result} messages.");
            Console.WriteLine($"After sending {result} messages you will have {n % m} credit left on your balance.");
        }
    }
}
