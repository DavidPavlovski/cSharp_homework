using Homework_06.Classes;
using System;

namespace Homework_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to car racing simulator!");
            BeginRace();

            while (true)
            {
                Console.Write("Would you like to race again (y/any)? ");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;

                }
                BeginRace();
                continue;

            }
        }

        public static void BeginRace()
        {
            Car[] cars = new Car[4] { new Car("Hyundai", 280), new Car("Mazda", 290), new Car("Ferrari", 320), new Car("Porsche", 380) };
            Driver[] drivers = new Driver[4] { new Driver("Bob", 3), new Driver("Greg", 2), new Driver("Jill", 4), new Driver("Anne", 5) };

            Console.WriteLine("\nPlayer one select your car and driver!");
            Car car1 = SelectCar(cars);
            car1.Driver = SelectDriver(drivers);

            Console.WriteLine("\nPlayer two select your car and driver!");
            Car car2 = SelectCar(cars);
            car2.Driver = SelectDriver(drivers);

            Car winner = Race(car1, car2);

            Console.WriteLine("\n");
            Console.WriteLine("****************");
            Console.WriteLine("*****Racing*****");
            Console.WriteLine("****************");

            Console.WriteLine($"\n**Driver : {winner.Driver.Name}, driving : {winner.Model} is the winner with a top speed of {winner.Speed}km/h**");
        }

        public static Driver SelectDriver(Driver[] drivers)
        {
            Console.WriteLine("\nSelect your driver.");
            for (int i = 0; i < drivers.Length; i++)
            {
                Driver driver = drivers[i];
                if (drivers[i].IsSelected)
                {
                    Console.WriteLine($"{i + 1}.{driver.Name} , skill level {driver.Skill} - selected");
                }
                else
                {
                    Console.WriteLine($"{i + 1}.{driver.Name} , skill level : {driver.Skill}");
                }
            }

            while (true)
            {
                Console.Write("Input driver number you want to select : ");
                if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > drivers.Length)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                else if (drivers[selection - 1].IsSelected)
                {
                    Console.WriteLine("Driver already selected , choose another driver!");
                    continue;
                }
                drivers[selection - 1].IsSelected = true;
                return drivers[selection - 1];
            }
        }

        public static Car SelectCar(Car[] cars)
        {
            Console.WriteLine("\nSelect your car.");

            for (int i = 0; i < cars.Length; i++)
            {
                Car car = cars[i];
                if (car.IsSelected)
                {
                    Console.WriteLine($"{i + 1}.{car.Model} , speed : {car.Speed}km/h - selected");
                }
                else
                {
                    Console.WriteLine($"{i + 1}.{car.Model} , speed : {car.Speed}km/h");
                }
            }
            while (true)
            {
                Console.Write("Enter car number you want to select : ");
                if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > cars.Length)
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                else if (cars[selection - 1].IsSelected)
                {
                    Console.WriteLine("Car already selected , choose another car");
                    continue;
                }
                cars[selection - 1].IsSelected = true;
                return cars[selection - 1];
            }
        }

        public static Car Race(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                return car1;
            }
            return car2;
        }

    }
}
