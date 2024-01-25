using TeachMeSkills;

var pulpitis = new Diagnosis("Pulpitis", 2);
var flu = new Diagnosis("Flu", 3);
var rupture = new Diagnosis("Rupture", 1);

Patient p1 = new Patient("Mike", new List<Diagnosis> { pulpitis, flu});
p1.AppointDoctors();
Patient p2 = new Patient("Sara", new List<Diagnosis> { rupture });
p2.AppointDoctors();
Patient p3 = new Patient("Kevin", new List<Diagnosis> { flu });
p3.AppointDoctors();
Patient p4 = new Patient("Chester", new List<Diagnosis> { pulpitis, flu, rupture });
p4.AppointDoctors();

p4.AppointPlans();

Console.WriteLine("Patient {0} treatment plan: ", p4.Name);
foreach (var plan in p4.Plans)
{
    Console.WriteLine(plan.Name);
}