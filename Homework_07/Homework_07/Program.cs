using Models;
using System;

namespace Homework_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Jon", "Doe", 2000, "IT");
            manager1.AddBonus(2000);

            Manager manager2 = new Manager("Jane", "Doe", 3000, "HR");
            manager2.AddBonus(5000);

            Contractor contractor1 = new Contractor("Bob", "Bobsky", 12, manager1);
            contractor1.AddWorkHours(2);
            contractor1.AddWorkHours(8);
            Console.WriteLine(contractor1.GetCurrentPosition());

            Contractor contractor2 = new Contractor("John", "Smith", 12, manager2);
            contractor2.AddWorkHours(4);
            contractor2.AddWorkHours(10);
            Console.WriteLine(contractor2.GetCurrentPosition());

            SalesPerson salesPerson = new SalesPerson("Jane", "Smith");
            salesPerson.AddSalesRevenue(400);
            salesPerson.AddSalesRevenue(2000);
            salesPerson.AddSalesRevenue(500);

            Employee[] Company = new Employee[] {
                manager1,
                manager2,
                contractor1,
                contractor2,
                salesPerson
            };

            CEO ElonMusk = new CEO("Elon", "Musk", 300000, Company, 200, 30.5);

            Console.WriteLine(ElonMusk.GetInfo());
            Console.WriteLine($"The salary of {ElonMusk.FullName} is : {ElonMusk.GetSalary():C}");
            Console.WriteLine("Employees : ");
            ElonMusk.PrintEmployees();
        }
    }
}
