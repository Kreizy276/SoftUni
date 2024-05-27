string type = Console.ReadLine();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int area = r * c;

double income = 0;

switch (type)
{
    case "Premiere":
        income = area * 12;
        break;
    case "Normal":
        income = area * 7.5;
        break;
    case "Discount":
        income = area * 5;
        break;
}

Console.WriteLine($"{income:f2} leva");