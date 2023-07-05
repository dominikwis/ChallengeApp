using ChallengeApp;

var supervisor = new Supervisor("Dominik", "Wiśniewski");
//supervisor.AddGrade(9f);
//supervisor.AddGrade(2);
//supervisor.AddGrade(60);
//supervisor.AddGrade('A');

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
                supervisor.AddGrade(character);
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
                supervisor.AddGrade(input);
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
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

var statistics = supervisor.GetStatiscics();

Console.WriteLine($"Min.: {statistics.Min}");
Console.WriteLine($"Max.: {statistics.Max}");
Console.WriteLine($"AVG.: {statistics.Average}");
Console.WriteLine($"Degree.: {statistics.AverageLetter}");