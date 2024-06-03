int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int counter = 0;
int failedCounter = 0;
int x = 0;
int y = 0;
bool isTrue = false;

for (x = n1; x <= n2; x++)
{
    for (y = n1; y <= n2; y++)
    {
        int result = x + y;
        counter++;
        if (result == n3)
        {
            isTrue = true;
            goto EndOfLoops;
        }
        if (result != n3)
        {
            isTrue = false;
            failedCounter++;
        }
    }
}

EndOfLoops:
if (isTrue)
{
    Console.WriteLine($"Combination N:{counter} ({x} + {y} = {n3})");
}
else
{
    Console.WriteLine($"{failedCounter} combinations - neither equals {n3}");
}
