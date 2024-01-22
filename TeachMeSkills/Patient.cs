namespace TeachMeSkills
{
    internal class Patient
    {
        public TreatmentPlan plan;
        public Doctor doctor;

        public Patient(TreatmentPlan plan)
        {
            this.plan = plan;
        }

        public void AppointDoctor()
        {
            switch (plan.code)
            {
                case 1:
                    doctor = new Surgeon();
                    break;
                case 2:
                    doctor = new Dentist();
                    break;
                default:
                    doctor = new Therapist();
                    break;
            }

            doctor.Treat();
        }
    }
}
