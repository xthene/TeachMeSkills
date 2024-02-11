using TeachMeSkills.Entities.Doctors;
using TeachMeSkills.Exceptions;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Entities
{
    public class Clinic
    {
        public List<Doctor> Doctors { get; private set; } = new List<Doctor>();
        public List<Patient> Patients { get; private set; } = new List<Patient>();
        public List<Reception> Receptions { get; private set; } = new List<Reception>();

        public delegate void ClinicHandler(string message);
        public event ClinicHandler? Notify;

        public Clinic(List<Doctor> doctors, List<Patient> patients, List<Reception> receptions)
        {
            Doctors = doctors;
            Patients = patients;
            Receptions = receptions;

            Notify += DisplayMessage;
        }

        public void HireDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void FireDoctor(Doctor doctor)
        {
            Doctors.Remove(doctor);
        }

        public void MakeAnAppointment(Patient patient, Doctor doctor, DateTime date)
        {
            try
            {
                //записаться можно только в рабочее время клиники
                if (date.TimeOfDay >= new TimeSpan(08, 00, 00) && date.TimeOfDay <= new TimeSpan(19, 30, 00))
                {
                    //если ещё нет записи к этому врачу на это время
                    if (!Receptions.Any(r => r.Doctor == doctor &&
                        Helper.IsTimeInRange(r.Begin, r.Begin + new TimeSpan(0, 0, 30, 0), date)))
                    {
                        Receptions?.Add(new Reception(doctor, date));
                        var message = "Patient " + patient.Name + " has an appointment with the " + doctor + " at " +
                            date.ToString() + " in " + doctor.Cabinet.GetType().Name;
                        Notify(message);
                    }
                    else
                    {
                        var message = "Appointment with the " + doctor + " is not available at " + date.ToString() +
                            ". Choose another time.";
                        Notify(message);
                    }
                }
                else { throw new BadTimeException("Clinic hours are from 8:00 to 20:00. Choose another time."); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetDoctorsSchedule()
        {
            Console.WriteLine("SCHEDULE");
            var schedule = Receptions?.OrderBy(r => r.Begin.Date);

            if (schedule != null && schedule.Any())
            {
                foreach (var reception in schedule)
                    Console.WriteLine(reception);
            }
        }

        public void GetDoctorSchedule(Doctor doctor)
        {
            Console.WriteLine("Schedule of {0} {1}", doctor.Specialization, doctor.Name);

            var schedule = Receptions.OrderBy(r => r.Begin.Date)
                .Where(r => r.Doctor == doctor);

            if (schedule != null && schedule.Any())
            {
                foreach (var reception in schedule)
                    Console.WriteLine(reception);
            }
        }

        void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
