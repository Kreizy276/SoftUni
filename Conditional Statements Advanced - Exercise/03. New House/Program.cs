string flower = Console.ReadLine();
int amount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double price = 0;

switch (flower)
{
    case "Roses":
        if (amount > 80)
        {
            price = (amount * 5) * 0.9;
        }
        else
        {
            price = amount * 5;
        }
        break;
    case "Dahlias":
        if (amount > 90)
        {
            price = (amount * 3.8) * 0.85;
        }
        else
        {
            price = amount * 3.8;
        }
        break;
    case "Tulips":
        if (amount > 80)
        {
            price = (amount * 2.8) * 0.85;
        }
        else
        {
            price = amount * 2.8;
        }
        break;
    case "Narcissus":
        if (amount < 120)
        {
            price = (amount * 3) * 1.15;
        }
        else
        {
            price = amount * 3;
        }
        break;
    case "Gladiolus":
        if (amount < 80)
        {
            price = (amount * 2.5) * 1.2;
        }
        else
        {
            price = amount * 2.5;
        }
        break;
}

if (price > budget)
{
    double neededMoney = price - budget;
    Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
}
else
{
    double leftMoney = budget - price;
    Console.WriteLine($"Hey, you have a great garden with {amount} {flower} and {leftMoney:f2} leva left.");
}
