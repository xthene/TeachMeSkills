namespace TeachMeSkills.Helpers
{
    internal static class Helper
    {
        static Diagnosis Pulpitis = new Diagnosis(TeachMeSkills.Diagnoses.Pulpitis, 2);
        static Diagnosis Flu = new Diagnosis(TeachMeSkills.Diagnoses.Flu, 3);
        static Diagnosis Rupture = new Diagnosis(TeachMeSkills.Diagnoses.Rupture, 1);

        public static List<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>() { Pulpitis, Flu, Rupture };

        public static bool IsTimeInRange(DateTime begin, DateTime end, DateTime time)
        {
            return time >= begin && time < end;
        }
    }
}
