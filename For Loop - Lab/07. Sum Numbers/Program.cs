int n = int.Parse(Console.ReadLine());

int result = 0;
int numbers = 0;

for(int i = 1; i <= n; i++)
{
    numbers = int.Parse(Console.ReadLine());
    result += numbers;
}

Console.WriteLine(result);