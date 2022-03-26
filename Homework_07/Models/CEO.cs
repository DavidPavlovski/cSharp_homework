using System;

namespace Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares, double sharesPrice)
            : base(firstName, lastName, Role.CEO, salary)
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
        }

        public void AddSharesPrice(double ammount)
        {
            SharesPrice += ammount;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
