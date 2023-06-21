namespace ChallengeApp
{
    public class User
    {
        public string Name { get; private set; }
        public string Password { get; private set; }

        private List<int> Scores = new List<int>();

        public int Result
        {
            get
            {
                return this.Scores.Sum();
            }
        }

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public User(string name)
        {
            this.Name = name;
        }

        public void AddScore(int score)
        {
            this.Scores.Add(score);
        }
    }
}
