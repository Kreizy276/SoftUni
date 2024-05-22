string command = Console.ReadLine();
double sum = 0;

while(command != "NoMoreMoney")
{
    double num = double.Parse(command);
    if(num <= 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {num:f2}");
    sum += num;

    command = Console.ReadLine();
}

Console.WriteLine($"Total: {sum:f2}");