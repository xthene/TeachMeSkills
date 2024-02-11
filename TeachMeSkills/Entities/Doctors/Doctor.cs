using TeachMeSkills.Entities.Cabinets;

namespace TeachMeSkills.Entities.Doctors
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
        public Cabinet Cabinet { get; set; }

        protected Doctor(string name, Specializations specialization) : base(name)
        {
            Name = name;
            Specialization = specialization;
            Cabinet = AssignCabinet();
        }

        protected Doctor(string name, double salary) : base(name)
        {
            Name = name;
            Salary = salary;
        }

        public abstract void Treat();

        protected Cabinet AssignCabinet()
        {
            var res = new Cabinet();
            switch (Specialization)
            {
                case Specializations.Dentist:
                    res = new Dental();
                    break;
                case Specializations.Surgeon:
                    res = new Surgical();
                    break;
                default:
                    res = new TherapistsOffice();
                    break;
            }

            return res;
        }

        public override string ToString()
        {
            return Specialization.ToString() + " " + base.Name;
        }
    }
}
