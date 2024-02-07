namespace TeachMeSkills.Entities
{
    public class TreatmentPlan
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public TreatmentPlan(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
}
