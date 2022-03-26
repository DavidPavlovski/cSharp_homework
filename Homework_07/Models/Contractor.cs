namespace Models
{
    public class Contractor : Employee
    {
        private double WorkHours { get; set; }
        private int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, int payPerHour, Manager responsible)
            : base(firstName, lastName, Role.Contractor, 0)
        {
            WorkHours = 0;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void AddWorkHours(int hours)
        {
            WorkHours += hours;
        }
        public string GetCurrentPosition()
        {
            return $"{Responsible.FullName} from the {Responsible.Department} department is responsible for {FullName}";
        }
    }
}
