namespace TeachMeSkills
{
    public class Surgeon : Doctor
    {
        public string? BodyPart { get; set; }

        public Surgeon()
        {
        }

        public Surgeon(string name) : base(name) { }
        public Surgeon(string name, double salary) : base(name, salary) { }

        public Surgeon(string name, double salary, string? bodyPart) : base(name, salary)
        {
            this.BodyPart = bodyPart;
        }
        public override void Treat()
        {
            Console.WriteLine("Surgeon treats");
        }
    }
}
