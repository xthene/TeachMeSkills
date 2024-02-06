namespace TeachMeSkills
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
            this.Name = name;
            this.Code = code;
        }

    }
}
