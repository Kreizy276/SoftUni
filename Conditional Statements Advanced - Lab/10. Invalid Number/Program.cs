int num = int.Parse(Console.ReadLine());

bool numTrue = num >= 100 && num <= 200 || num == 0;

if (numTrue != true)
{
    Console.WriteLine("invalid");
}
