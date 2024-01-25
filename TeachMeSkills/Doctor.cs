namespace TeachMeSkills
{
    public abstract class Doctor : Employee
    {
        private double Salary { get; set; }

        protected Doctor(string name) : base(name)
        {
            this.Name = name;
        }

        protected Doctor(string name, double salary) : base(name)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public abstract void Treat();
    }
}
