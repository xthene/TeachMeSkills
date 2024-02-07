using TeachMeSkills.Entities;
using TeachMeSkills.Entities.Doctors;

Clinic clinic24 = new Clinic();

foreach (var patient in clinic24.Patients)
{
    patient.AppointDoctors(clinic24.Doctors);
}

clinic24.Patients.FirstOrDefault(p => p.Name == "Mike")?.AppointPlans();

clinic24.MakeAnAppointment(clinic24.Patients.FirstOrDefault(p => p.Name == "Mike"),
    clinic24.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 10, 00, 00));
clinic24?.MakeAnAppointment(clinic24.Patients.FirstOrDefault(p => p.Name == "Kevin"),
    clinic24.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 10, 00, 00));
clinic24?.MakeAnAppointment(clinic24.Patients.FirstOrDefault(p => p.Name == "Kevin"),
    clinic24.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 21, 00, 00));

