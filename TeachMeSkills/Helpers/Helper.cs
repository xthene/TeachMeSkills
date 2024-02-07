using TeachMeSkills.Entities;

namespace TeachMeSkills.Helpers
{
    internal static class Helper
    {
        static Diagnosis Pulpitis = new Diagnosis(Entities.Diagnoses.Pulpitis, 2);
        static Diagnosis Flu = new Diagnosis(Entities.Diagnoses.Flu, 3);
        static Diagnosis Rupture = new Diagnosis(Entities.Diagnoses.Rupture, 1);

        public static List<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>() { Pulpitis, Flu, Rupture };

        public static bool IsTimeInRange(DateTime begin, DateTime end, DateTime time)
        {
            return time >= begin && time < end;
        }
    }
}
