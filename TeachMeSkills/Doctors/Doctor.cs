namespace TeachMeSkills.Doctors
{
    public enum Specializations
    {
        Dentist,
        Surgeon,
        Therapist
    }
    public abstract class Doctor : Employee
    {
        private double Salary { get; set; }
        public Specializations Specialization { get; set; }

        protected Doctor(string name, Specializations specialization) : base(name)
        {
            Name = name;
            Specialization = specialization;
        }

        protected Doctor(string name, double salary) : base(name)
        {
            Name = name;
            Salary = salary;
        }

        public abstract void Treat();
    }
}
