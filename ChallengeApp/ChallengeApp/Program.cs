using ChallengeApp;

Employee employee1 = new Employee("Dominik", "Wiśniewski", 28);
Employee employee2 = new Employee("Natalia", "Dziurka", 26);
Employee employee3 = new Employee("Dawid", "Goliwąs", 30);

employee1.addScore(new int[] { 1, 5, 6, 8, 6 });
employee2.addScore(new int[] { 8, 2, 1, 1, 10 });
employee3.addScore(new int[] { 4, 4, 3, 5, 7 });

List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };

int[] sumsOfScores = new int[3];
int sums = 0;

foreach (var employee in employees)
{
    sumsOfScores[sums] = employee.Result;
    sums++;
}

int maxResult = sumsOfScores.Max();
Employee employeeWithMaxResult = null;

foreach (var emp in employees)
{
    if (emp.Result == maxResult)
    {
        employeeWithMaxResult = emp;
    }
}

Console.WriteLine("Spośród wszystkich pracowników, wygrywa: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age + " z wynikiem: " + employeeWithMaxResult.Result + " pkt.");