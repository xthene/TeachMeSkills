namespace TeachMeSkills
{
    public class Therapist : Doctor
    {
        public Therapist()
        {

        }
        public Therapist(string name) : base(name) { }
        public Therapist(string name, double salary) : base(name, salary) { }
        public override void Treat()
        {
            Console.WriteLine("Therapist treats ");
        }
    }
}
