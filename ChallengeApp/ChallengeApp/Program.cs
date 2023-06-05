var name = "Ewa";
bool woman = false;
var age = 16;

if (age < 30 && woman)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa" && woman)
{
    Console.WriteLine(name + ", lat " + age);
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni");
    if (!woman)
    {
        Console.WriteLine("Mężczyzna");
    }
}