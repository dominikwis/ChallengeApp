int number = 20230707;
char[] numberAsChar = number.ToString().ToCharArray();
char[] amount = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
int[] results = new int[10];

foreach (char item in numberAsChar)
{
        for (int i = 0; i < 10; i++)
        {
            if (amount[i] == item)
            {
                results[i] += 1;
            }
        }
}
for (int a = 0; a < 10; a++)
{
    Console.WriteLine(amount[a] + " => " + results[a]);
}