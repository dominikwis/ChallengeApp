using ChallengeApp;

var employee = new Employee("Dominik", "Wiśniewski");
//employee.AddGrade("Dominik");
//employee.AddGrade("4000");
//employee.AddGrade(4.125456789);
//employee.AddGrade("1.123456789");
//employee.AddGrade(21474836471);
//employee.AddGrade('a');
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatiscics();
var statistics2 = employee.GetStatisticsWithfor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Foreach:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}\n");

Console.WriteLine("For:");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}\n");

Console.WriteLine("While:");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}\n");

Console.WriteLine("Do While:");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}\n");