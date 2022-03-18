using System;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dobYear, dobMonth, dobDay;
            while (true)
            {
                Console.Write("Enter your birth year : ");
                if (!int.TryParse(Console.ReadLine(), out dobYear))
                {
                    Console.WriteLine("Input must be a valid number");
                    continue;
                }
                else if (dobYear > DateTime.Now.Year || dobYear < 0)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter your birth month : ");
                if (!int.TryParse(Console.ReadLine(), out dobMonth))
                {
                    Console.WriteLine("Input must be a valid number");
                    continue;
                }
                else if (dobMonth < 1 || dobMonth > 12)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter your birth day : ");
                if (!int.TryParse(Console.ReadLine(), out dobDay))
                {
                    Console.WriteLine("Input must be a valid number.");
                    continue;
                }
                else if (dobDay > DateTime.DaysInMonth(dobYear, dobMonth) || dobDay < 1)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                break;
            }

            int age = AgeCalculator(new DateTime(dobYear, dobMonth, dobDay));
            if (DateTime.Now.Month == dobMonth && DateTime.Now.Day == dobDay)
            {
                Console.WriteLine("Happy Birthday!!!");
            }
            Console.WriteLine($"You are {age} years old ");
        }

        public static int AgeCalculator(DateTime dob)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dob.Year;

            if (dob.Month > currentDate.Month || (currentDate.Month == dob.Month && dob.Day > currentDate.Day))
            {
                age--;
            }

            //if (dob > currentDate.AddYears(-age))
            //{
            //    age--;
            //}

            return age;
        }
    }
}
