namespace TeachMeSkills.Entities
{
    public enum Diagnoses
    {
        Pulpitis,
        Flu,
        Rupture
    }

    public class Diagnosis
    {
        public Diagnoses Name { get; set; }
        public int Code { get; set; }

        public Diagnosis(Diagnoses name, int code)
        {
            Name = name;
            Code = code;
        }

    }
}
