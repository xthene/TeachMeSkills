namespace TeachMeSkills
{
    public class Dentist : Doctor
    {
        public Dentist(string name) : base(name)
        {
        }

        public Dentist(string name, double salary) : base(name, salary)
        {
        }

        public override void Treat()
        {
            Console.WriteLine("Dentist treat");
        }

        public override void Work()
        {
            Console.WriteLine("Work as a dentist");
        }
    }
}
