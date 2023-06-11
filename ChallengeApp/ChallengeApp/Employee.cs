namespace ChallengeApp
{
    public class Employee
    {
        private List<int> Scores = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.Scores.Sum();
            }
        }

        public void addScore(int[] scores)
        {
            foreach (int score in scores)
            {
                this.Scores.Add(score);
            }
        }

        public void addNegativeScore(int[] negativeScores)
        {
            foreach (int negativeScore in negativeScores)
            {
                this.Scores.Add(negativeScore);
            }
        }
    }
}
