namespace TeachMeSkills
{
    public class Dentist : Doctor
    {
        public Dentist()
        {

        }
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
    }
}
