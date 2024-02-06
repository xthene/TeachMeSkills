using TeachMeSkills.Interfaces;

namespace TeachMeSkills
{
    public abstract class Employee : IWorkable
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            this.Name = name;
        }

        public virtual void Work()
        {
            throw new NotImplementedException();
        }
    }
}
