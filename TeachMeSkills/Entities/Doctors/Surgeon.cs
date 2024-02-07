namespace TeachMeSkills.Entities.Doctors
{
    public class Surgeon : Doctor
    {
        public string? BodyPart { get; set; }

        public Surgeon(string name, Specializations specialization) : base(name, specialization) { }
        public Surgeon(string name, double salary) : base(name, salary) { }

        public Surgeon(string name, double salary, string? bodyPart) : base(name, salary)
        {
            BodyPart = bodyPart;
        }
        public override void Treat()
        {
            Console.WriteLine("Surgeon treats");
        }

        public override void Work()
        {
            Console.WriteLine("Work as a surgeon");
        }
    }
}
