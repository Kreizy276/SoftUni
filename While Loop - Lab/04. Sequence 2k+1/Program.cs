int n = int.Parse(Console.ReadLine());

int sum = 0;

while (true)
{
    sum = 2 * sum + 1;
    if(sum <= n)
    {
        Console.WriteLine(sum);
    }
    else
    {
        break;
    }
}