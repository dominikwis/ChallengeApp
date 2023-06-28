using ChallengeApp;

var employee = new Employee("Dominik", "Wiśniewski");
employee.AddGrade("Dominik");
employee.AddGrade("4000");
employee.AddGrade(4.125456789);
employee.AddGrade("1.123456789");
employee.AddGrade(21474836471);
employee.AddGrade('a');
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatiscics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");