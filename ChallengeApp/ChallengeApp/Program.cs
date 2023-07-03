using ChallengeApp;

var employee = new Employee("Dominik", "Wiśniewski");
employee.AddGrade(9f);
employee.AddGrade(2);
employee.AddGrade(60);
employee.AddGrade('A');

Console.WriteLine("Witamy w programie Xyz do oceny pracowników");
Console.WriteLine("============================================\n");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    employee.AddGrade(input);
}

var statistics = employee.GetStatiscics();

Console.WriteLine($"Min.: {statistics.Min}");
Console.WriteLine($"Max.: {statistics.Max}");
Console.WriteLine($"AVG.: {statistics.Average}");
Console.WriteLine($"Degree.: {statistics.AverageLetter}");