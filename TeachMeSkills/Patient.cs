namespace TeachMeSkills
{
    public class Patient
    {
        TreatmentPlan Plan { get; set; }
        private Doctor? Doctor { get; set; }

        public Patient(TreatmentPlan plan)
        {
            this.Plan = plan;
        }

        public void AppointDoctor()
        {
            switch (Plan.Code)
            {
                case 1:
                    Doctor = new Surgeon();
                    break;
                case 2:
                    Doctor = new Dentist();
                    break;
                default:
                    Doctor = new Therapist();
                    break;
            }

            Doctor.Treat();
        }
    }
}
