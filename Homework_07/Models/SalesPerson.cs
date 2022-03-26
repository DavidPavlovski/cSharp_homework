namespace Models
{
    public class SalesPerson : Employee
    {
        private double SalesRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 500)
        {
            SalesRevenue = 0;
        }
        public void AddSalesRevenue(double revenue)
        {
            SalesRevenue += revenue;
        }
        public override double GetSalary()
        {
            double bonus = 500;
            if(SalesRevenue > 2000 && SalesRevenue <= 5000)
            {
                bonus = 1000;
            } else if(SalesRevenue > 5000)
            {
                bonus = 1500;
            }
            return Salary + bonus;
        }
    }
}
