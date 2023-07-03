namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckIfResultOfGetStatisticsWorks()
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

        [Test]
        public void CheckIfAddGradeWithLetterWorks()
        {
            // arrange (przygotowanie) np tworze zmienne
            var employer = new Employee("Dominik", "Wiśniewski");
            employer.AddGrade('B');
            employer.AddGrade('a');

            // act (wykonanie) np. przypisuje zmienną wykonywanej metody
            var statistics = employer.GetStatiscics();

            //assert (sprawdzenie warunków)
            Assert.AreEqual(statistics.AverageLetter, 'A');
        }

        [Test]
        public void CheckIfAddGradeLetterWithWalidationWorks()
        {
            // arrange (przygotowanie) np tworze zmienne
            var employer = new Employee("Dominik", "Wiśniewski");
            employer.AddGrade('z');
            employer.AddGrade('h');

            // act (wykonanie) np. przypisuje zmienną wykonywanej metody
            var statistics = employer.GetStatiscics();

            //assert (sprawdzenie warunków)
            Assert.AreEqual(statistics.AverageLetter, 'E');
        }
    }
}
