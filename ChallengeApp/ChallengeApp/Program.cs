using ChallengeApp;

var employee = new Employee("Dominik", "Wiśniewski");
employee.AddGrade(9f);
employee.AddGrade(2);
employee.AddGrade(60);

//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch (Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}

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
    else if (input.Length == 1)
    {
        if (char.IsLetter(input[0]))
        {
            char character = input[0];

            try
            {
                employee.AddGrade(character);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        else
        {
            try
            {
                employee.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
    }
    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

var statistics = employee.GetStatiscics();

Console.WriteLine($"Min.: {statistics.Min}");
Console.WriteLine($"Max.: {statistics.Max}");
Console.WriteLine($"AVG.: {statistics.Average}");
Console.WriteLine($"Degree.: {statistics.AverageLetter}");