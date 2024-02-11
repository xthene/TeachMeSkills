using TeachMeSkills.Entities;
using TeachMeSkills.Entities.Doctors;
using TeachMeSkills.Helpers;

Clinic CreateClinic()
{
    Doctor DentistVasya = new Dentist("Vasya", Specializations.Dentist);
    Doctor DentistPetya = new Dentist("Petya", Specializations.Dentist);
    Doctor SurgeonSveta = new Surgeon("Sveta", Specializations.Surgeon);
    Doctor TherapistKolya = new Therapist("Kolya", Specializations.Therapist);

    var doctors = new List<Doctor>() { DentistVasya, DentistPetya, SurgeonSveta, TherapistKolya };

    Patient p1 = new Patient("Mike", new List<Diagnosis>() { Helper.Diagnoses
                .FirstOrDefault(d => d.Name == Diagnoses.Rupture), Helper.Diagnoses.FirstOrDefault(d => d.Name == Diagnoses.Flu) });
    Patient p2 = new Patient("Sara", new List<Diagnosis> { Helper.Diagnoses
                .FirstOrDefault(d => d.Name == Diagnoses.Rupture) });
    Patient p3 = new Patient("Kevin", new List<Diagnosis> { Helper.Diagnoses.
                FirstOrDefault(d => d.Name == Diagnoses.Flu) });
    Patient p4 = new Patient("Chester", new List<Diagnosis>(Helper.Diagnoses));

    var patients = new List<Patient> { p1, p2, p3, p4 };

    Reception r1 = new Reception(DentistVasya, new DateTime(2024, 02, 01, 09, 00, 00));
    Reception r2 = new Reception(SurgeonSveta, new DateTime(2024, 02, 01, 09, 00, 00));
    Reception r3 = new Reception(SurgeonSveta, new DateTime(2024, 02, 02, 09, 00, 00));

    var receptions = new List<Reception>() { r1, r2, r3 };

    return new Clinic(doctors, patients, receptions);
}

Clinic clinic = CreateClinic();

foreach (var patient in clinic.Patients)
{
    patient.AppointDoctors(clinic.Doctors);
}

clinic.Patients.FirstOrDefault(p => p.Name == "Mike")?.AppointPlans();

clinic.MakeAnAppointment(clinic.Patients.FirstOrDefault(p => p.Name == "Mike"),
    clinic.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 10, 00, 00));
clinic?.MakeAnAppointment(clinic.Patients.FirstOrDefault(p => p.Name == "Kevin"),
    clinic.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 10, 00, 00));
clinic?.MakeAnAppointment(clinic.Patients.FirstOrDefault(p => p.Name == "Kevin"),
    clinic.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Therapist && d.Name == "Kolya"),
    new DateTime(2024, 02, 06, 21, 00, 00));

clinic?.GetDoctorsSchedule();
clinic?.GetDoctorSchedule(clinic?.Doctors.FirstOrDefault(d => d.Specialization == Specializations.Surgeon && d.Name == "Sveta"));


