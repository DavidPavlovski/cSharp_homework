namespace Models
{
    public class Manager : Employee
    {
        public string Department { get; set; }
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName , double salary , string department)
            : base(firstName, lastName,Role.Manager , salary)
        {
            Department = department;
            Bonus = 0;
        }
        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
