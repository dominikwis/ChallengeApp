using ChallengeApp;

var employee = new Employee("Dominik", "Wiśniewski");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatiscics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

// Zadanie domowe Możliwość dodawania ocen i wyświetlania raportu narazie dla jednego pracownika. Napisac kilka testów które to pozwolą sprawdzić
// czy metoda zwracająca statystyki działa prawidłowo. Na pewno jest przypadek, gdzie testy wykryją nie prawidłowe działanie
// w kolejnym dniu Adam pokaże jak on to zrobił 