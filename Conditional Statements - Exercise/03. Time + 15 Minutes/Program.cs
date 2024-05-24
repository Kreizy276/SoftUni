int hour1 = int.Parse(Console.ReadLine());
int min1 = int.Parse(Console.ReadLine());

int min = min1 + 15;
int hour = hour1 + min / 60;
int min2 = min % 60;

if (hour == 24)
{
    hour = 0;
}
if (min2 < 10)
{
    Console.WriteLine($"{hour}:{min2:d2}");
}
else
{
    Console.WriteLine($"{hour}:{min2}");
}