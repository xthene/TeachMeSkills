using TeachMeSkills.Interfaces;

namespace TeachMeSkills.Entities
{
    public abstract class Employee : IWorkable
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            throw new NotImplementedException();
        }
    }
}
