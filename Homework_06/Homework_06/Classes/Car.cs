namespace Homework_06.Classes
{
    internal class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }
        public bool IsSelected {get; set; }

        public Car()
        {

        }
        public Car(string model, double speed)
        {
            Model = model;
            Speed = speed;
        }

        public double CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }
    }
}
