namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectReasult()
        {
            // arrange (przygotowanie)
            var user = new User("Login", "asddas324");
            user.AddScore(5);
            user.AddScore(6);

            // act (wykonanie)
            var result = user.Result;

            //assert (sprawdzenie warunków)
            Assert.AreEqual(11, result);
        }
    }
}