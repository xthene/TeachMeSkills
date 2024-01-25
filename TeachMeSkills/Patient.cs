namespace TeachMeSkills
{
    public class Patient : ITreatable
    {
        public string Name { get; set; }
        public List<TreatmentPlan> Plans {  get; set; } = new List<TreatmentPlan>();
        private List<Doctor> Doctors { get; set; } = new List<Doctor>();
        private List<Diagnosis> Diagnoses { get; set; }

        public Patient(string name, List<Diagnosis> diagnoses)
        {
            this.Name = name;
            this.Diagnoses = diagnoses;
        }

        public void AppointPlans()
        {
            foreach (var diagnosis in Diagnoses)
            {
                Plans.Add(new TreatmentPlan("treatment plan for " + diagnosis.Name, diagnosis.Code));
            }
        }

        public void AppointDoctors()
        {
            foreach (var diagnosis in Diagnoses)
            {
                switch (diagnosis.Code)
                {
                    case 1:
                        Doctors.Add(new Surgeon("surgeon"));
                        break;
                    case 2:
                        Doctors.Add(new Dentist("dentist"));
                        break;
                    default:
                        Doctors.Add(new Therapist("therapist"));
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
