using TeachMeSkills.Doctors;

namespace TeachMeSkills
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
    }
}
