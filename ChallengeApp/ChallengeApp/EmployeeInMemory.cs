namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            // podobnie będzie jak w Employee
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(long grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override Statiscics GetStatiscics()
        {
            throw new NotImplementedException();
        }
    }
}
