namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckResultOfGetStatisticsFunctions()
        {
            // arrange (przygotowanie) np tworze zmienne
            var employer = new Employee("Kinga", "Dzegan");
            employer.AddGrade(8.4f);
            employer.AddGrade(1.2f);
            employer.AddGrade(5.9f);

            // act (wykonanie) np. przypisuje zmienną wykonywanej metody
            var result = employer.GetStatiscics();

            //assert (sprawdzenie warunków)
            Assert.AreEqual(result.Min, 1.2f);
            Assert.AreEqual(result.Max, 8.4f);
            Assert.AreEqual(Math.Round(result.Average, 2), Math.Round(5.166666666666667, 2));
        }
    }
}
