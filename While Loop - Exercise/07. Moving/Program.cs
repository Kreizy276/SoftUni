int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

int volume = a * b * h;
int sum = 0;
int num = 0;
string input = "";

while (sum < volume)
{
    input = Console.ReadLine();
    if (input != "Done")
    {
        num = int.Parse(input);
        sum += num;
    }
    else
    {
        break;
    }
}

if(sum > volume)
{
    int neededSpace = Math.Abs(sum - volume);
    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
}
else
{
    int spaceLeft = volume - sum;
    Console.WriteLine($"{spaceLeft} Cubic meters left.");
}