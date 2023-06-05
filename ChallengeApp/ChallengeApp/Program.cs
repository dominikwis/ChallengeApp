var name = "Ewa";
bool woman = true;
var age = 32;

if (age < 30 && age >= 18 && woman)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa" && woman)
{
    Console.WriteLine(name + ", lat " + age);
}
else if (age < 18)
{
    if (!woman)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletnia Dziewczyna");
    }
}
else
{
    Console.WriteLine("Kobieta powyżej 30-stki");
    if (!woman)
    {
        Console.WriteLine("Mężczyzna powyżej 30-stki");
    }
}