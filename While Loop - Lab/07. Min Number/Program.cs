int min = int.MaxValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int num = int.Parse(input);
    if(num < min)
    {
        min = num;
    }

    input = Console.ReadLine();
}

Console.WriteLine(min);