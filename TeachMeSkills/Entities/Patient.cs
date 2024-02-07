using TeachMeSkills.Entities.Doctors;
using TeachMeSkills.Interfaces;

namespace TeachMeSkills.Entities
{
    public class Patient : ITreatable
    {
        public string Name { get; set; }
        public List<TreatmentPlan> Plans { get; set; } = new List<TreatmentPlan>();
        private List<Doctor> Doctors { get; set; } = new List<Doctor>();
        private List<Diagnosis> Diagnoses { get; set; }

        public Patient(string name, List<Diagnosis> diagnoses)
        {
            Name = name;
            Diagnoses = diagnoses;
        }

        public void AppointPlans()
        {
            foreach (var diagnosis in Diagnoses)
            {
                var plan = new TreatmentPlan("Treatment plan for " + diagnosis.Name, diagnosis.Code);
                Plans.Add(plan);

                Console.WriteLine("{0} appointed for {1}", plan.Name, Name);
            }
        }

        public void AppointDoctors(List<Doctor> doctors)
        {
            foreach (var diagnosis in Diagnoses)
            {
                switch (diagnosis.Code)
                {
                    case 1:
                        Doctors.Add(doctors.FirstOrDefault(d => d.Specialization == Specializations.Surgeon));
                        break;
                    case 2:
                        Doctors.Add(doctors.FirstOrDefault(d => d.Specialization == Specializations.Dentist));
                        break;
                    default:
                        Doctors.Add(doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist));
                        break;
                }
            }

            foreach (var doc in Doctors)
            {
                doc.Treat();
            }
        }

        public void GetTreatment()
        {

        }
    }
}
