using TeachMeSkills.Entities.Doctors;
using TeachMeSkills.Helpers;

namespace TeachMeSkills.Entities
{
    public class Clinic
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Reception> Receptions { get; set; } = new List<Reception>();

        public delegate void ClinicHandler(string message);
        public event ClinicHandler? Notify;

        public Clinic()
        {
            InitializePatients();
            InitializeDoctors();
            InitializeReceptions();

            Notify += DisplayMessage;
        }

        void InitializePatients()
        {
            Patient p1 = new Patient("Mike", new List<Diagnosis>() { Helper.Diagnoses
                .FirstOrDefault(d => d.Name == Diagnoses.Rupture), Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Flu) });
            Patient p2 = new Patient("Sara", new List<Diagnosis> { Helper.Diagnoses
                .FirstOrDefault(d => d.Name == Diagnoses.Rupture) });
            Patient p3 = new Patient("Kevin", new List<Diagnosis> { Helper.Diagnoses.
                FirstOrDefault(d => d.Name == Diagnoses.Flu) });
            Patient p4 = new Patient("Chester", new List<Diagnosis>(Helper.Diagnoses));

            Patients = new List<Patient> { p1, p2, p3, p4 };
        }
        void InitializeDoctors()
        {
            Doctor Dentist = new Dentist("Vasya", Specializations.Dentist);
            Doctor Surgeon = new Surgeon("Sveta", Specializations.Surgeon);
            Doctor Therapist = new Therapist("Kolya", Specializations.Therapist);

            Doctors = new List<Doctor>() { Dentist, Surgeon, Therapist };
        }

        void InitializeReceptions()
        {
            Reception r1 = new Reception(Doctors.FirstOrDefault(d => d.Specialization == Specializations.Dentist),
                new DateTime(2024, 02, 01, 09, 00, 00));
            Reception r2 = new Reception(Doctors.FirstOrDefault(d => d.Specialization == Specializations.Surgeon),
                new DateTime(2024, 02, 01, 09, 00, 00));

            Receptions = new List<Reception>() { r1, r2 };
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
                        var message = "Patient " + patient.Name + " has an appointment with the " + doctor.Specialization +
                            " " + doctor.Name + " at " + date.ToString() + " in " + doctor.Cabinet.GetType().Name;
                        Notify(message);
                    }
                    else
                    {
                        var message = "Appointment with the " + doctor.Specialization + " " + doctor.Name +
                            " is not available at " + date.ToString() + ". Choose another time.";
                        Notify(message);
                    }
                }
                else { throw new Exception("Clinic hours are from 8:00 to 20:00. Choose another time."); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
