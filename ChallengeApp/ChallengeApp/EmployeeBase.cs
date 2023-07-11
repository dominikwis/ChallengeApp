namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public virtual void OnGradeAdded()
        {
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(char grade);

        public abstract Statiscics GetStatiscics();
    }
}
