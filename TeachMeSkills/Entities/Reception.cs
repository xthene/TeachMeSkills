using TeachMeSkills.Entities.Doctors;

namespace TeachMeSkills.Entities
{
    public class Reception
    {
        public Doctor Doctor;
        public DateTime Begin;
        public DateTime End;

        public Reception(Doctor doctor, DateTime begin)
        {
            Doctor = doctor;
            Begin = begin;
            End = begin + new TimeSpan(0, 0, 30, 0);
        }

        public override string ToString()
        {
            return "Specialization: " + Doctor.Specialization + " Name: " + Doctor.Name + " Date: " + Begin.Date.ToShortDateString() +
                " Time: " + Begin.TimeOfDay.ToString();
        }
    }
}
