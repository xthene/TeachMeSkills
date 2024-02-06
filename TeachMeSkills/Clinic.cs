using System.Xml.Linq;
using TeachMeSkills.Doctors;
using TeachMeSkills.Helpers;

namespace TeachMeSkills
{
    public class Clinic
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Reception> Receptions { get; set; } = new List<Reception>();

        public Clinic()
        {
            InitializePatients();
            InitializeDoctors();
            InitializeReceptions();
        }

        void InitializePatients()
        {
            Patient p1 = new Patient("Mike", [Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Rupture),
                Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Flu)]);
            Patient p2 = new Patient("Sara", [Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Rupture)]);
            Patient p3 = new Patient("Kevin", [Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Flu)]);
            Patient p4 = new Patient("Chester", Helper.Diagnoses);

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
            if (date.TimeOfDay >= new TimeSpan(08, 00, 00) && date.TimeOfDay <= new TimeSpan(19, 30, 00))
            {
                if (!(Receptions.Any(r => r.Doctor == doctor &&
                    Helper.IsTimeInRange(r.Begin, r.Begin + new TimeSpan(0, 0, 30, 0), date))))
                {
                    var reception = new Reception(doctor, date);
                    Receptions?.Add(reception);
                    Console.WriteLine("Patient {0} has an appointment with the {1} {2} at {3}", patient.Name, 
                        doctor.Specialization, doctor.Name, date.ToString());
                }
                else
                {
                    Console.WriteLine("Appointment with the {0} {1} is not available at {2}. Choose another time.",
                        doctor.Specialization, doctor.Name, date.ToString());
                }
            } else { Console.WriteLine("Clinic hours are from 8:00 to 20:00. Choose another time"); }
        }
    }
}
