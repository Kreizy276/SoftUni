int n = int.Parse(Console.ReadLine());

int nums = 0;
int max = int.MinValue;
int sum = 0;

for (int i = 1; i <= n; i++)
{
    nums = int.Parse(Console.ReadLine());
    sum += nums;
    if(nums > max)
    {
        max = nums;
    }
}

sum -= max;

if (sum == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    int diff = Math.Abs(max - sum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}