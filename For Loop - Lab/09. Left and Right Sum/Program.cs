int n = int.Parse(Console.ReadLine());

int numbers = 0;
int sumLeft = 0;
int sumRight = 0;

n *= 2;
for (int i = 1; i <= n; i++)
{
    numbers = int.Parse(Console.ReadLine());
    if(i <= n - i)
    {
        sumLeft += numbers;
    }
    else if (i > n - i && i <= n)
    {
        sumRight += numbers;
    }
}

if (sumLeft == sumRight)
{
    int totalSum = sumLeft;
    Console.WriteLine($"Yes, sum = {totalSum}");
}
else
{
    int diff = Math.Abs(sumLeft - sumRight);
    Console.WriteLine($"No, diff = {diff}");
}