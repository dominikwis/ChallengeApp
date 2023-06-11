namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ShouldCountSumOfArray_WhenUseAddScore()
        {
            //Arrange
            var employee1 = new Employee("Dominik", "Kwaœniewski", 28);
            employee1.addScore(new int[] { 1, 5 });

            //Act
            var result = employee1.Result;

            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void ShouldIdentifyNegativeScores_WhenUseAddNegativeScore()
        {
            //Arrange
            var employee1 = new Employee("Natalia", "Dziurka", 26);
            employee1.addScore(new int[] { 1, 5, 2 });
            employee1.addNegativeScore(new int[] {-3, -5});

            //Act
            var result = employee1.Result;

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}