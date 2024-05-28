int n = int.Parse(Console.ReadLine());

int nEven = 0;
int nOdd = 0;
int sumEven = 0;
int sumOdd = 0;

for (int i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        nEven = int.Parse(Console.ReadLine());
        sumEven += nEven;
    }
    else
    {
        nOdd = int.Parse(Console.ReadLine());
        sumOdd += nOdd;
    }
}

if (sumEven == sumOdd)
{
    int totalSum = sumEven;
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {totalSum}");
}
else
{
    int diff = Math.Abs(sumEven - sumOdd);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}