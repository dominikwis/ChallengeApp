namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoTypeOfFloat()
        {
            // arrange (przygotowanie)
            float number1 = 1.921f;
            float number2 = 4.999f;

            //assert (sprawdzenie warunków)
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void CompareTwoTypeOfInt()
        {
            // arrange (przygotowanie)
            int number1 = 1;
            int number2 = 1;

            //assert (sprawdzenie warunków)
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareTwoTypeOfString()
        {
            // arrange (przygotowanie)
            string string1 = "przykład1";
            string string2 = "przykład1";

            //assert (sprawdzenie warunków)
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange (przygotowanie)
            var user1 = GetUser("Dominik");
            var user2 = GetUser("Dominik");

            //assert (sprawdzenie warunków)
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
