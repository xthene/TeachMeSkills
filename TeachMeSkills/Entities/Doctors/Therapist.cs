namespace TeachMeSkills.Entities.Doctors
{
    public class Therapist : Doctor
    {
        public Therapist(string name, Specializations specialization) : base(name, specialization) { }
        public Therapist(string name, double salary) : base(name, salary) { }
        public override void Treat()
        {
            Console.WriteLine("Therapist treats ");
        }

        public override void Work()
        {
            Console.WriteLine("Work as a therapist");
        }
    }
}
