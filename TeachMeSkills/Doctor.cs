namespace TeachMeSkills
{
    public abstract class Doctor
    {
        string Name { get; set; }
        private double Salary { get; set; }

        protected Doctor()
        {
        }

        protected Doctor(string name)
        {
            this.Name = name;
        }

        protected Doctor(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public abstract void Treat();
    }
}
