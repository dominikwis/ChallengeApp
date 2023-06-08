namespace ChallengeApp
{
    public class User
    {
        //za pomocą static możemy odwołać się bezpośrednio z "typu" (w tym przypadku User) do tej zmiennej nie odwołując się do obiektu.
        public static string GameName = "Diablo";

        //private to modyfikator dostępu. Jeśli byłoby public, to można byłoby zawsze zmienić wynik na zewnątrz klasy a tak to trzeba to zrobić przez metode.
        private List<int> score = new List<int>();

        //constructor
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        //Pola - property w tym ustawiam, czy można odczytywać czy ustawiać czy nic z tych rzeczy. Odnosi się to do zmiennych z konstruktora
        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        //Metoda void oznacza, że nic nie zwraca, przypisuje score wynik z zewnątrz klasy
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
