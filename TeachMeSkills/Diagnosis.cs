namespace TeachMeSkills
{
    public class Diagnosis
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Diagnosis(string name, int code)
        {
            this.Name = name;
            this.Code = code;
        }

    }
}
