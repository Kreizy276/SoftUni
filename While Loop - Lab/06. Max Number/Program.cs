int max = int.MinValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int num = int.Parse(input);
    if(num > max)
    {
        max = num;
    }

    input = Console.ReadLine();
}

Console.WriteLine(max);