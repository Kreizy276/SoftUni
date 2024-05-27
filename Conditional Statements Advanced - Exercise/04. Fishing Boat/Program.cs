int budget = int.Parse(Console.ReadLine());
string season = (Console.ReadLine());
int fisherMen = int.Parse(Console.ReadLine());

double priceSeason = 0;
double price = 0;
bool isEven = fisherMen % 2 == 0;

switch (season)
{
    case "Summer":
        priceSeason = 4200;
        switch (isEven)
        {
            case false:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                }
                else
                {
                    price = priceSeason * 0.75;
                }
                break;
            default:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                    price = price * 0.95;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                    price = price * 0.95;

                }
                else
                {
                    price = priceSeason * 0.75;
                    price = price * 0.95;
                }
                break;
        }
        break;
    case "Spring":
        priceSeason = 3000;
        switch (isEven)
        {
            case false:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                }
                else
                {
                    price = priceSeason * 0.75;
                }
                break;
            default:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                    price = price * 0.95;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                    price = price * 0.95;

                }
                else
                {
                    price = priceSeason * 0.75;
                    price = price * 0.95;
                }
                break;
        }
        break;
    case "Autumn":
        priceSeason = 4200;
        if (fisherMen <= 6)
        {
            price = priceSeason * 0.9;
        }
        else if (fisherMen > 7 && fisherMen <= 11)
        {
            price = priceSeason * 0.85;
        }
        else
        {
            price = priceSeason * 0.75;
        }
        break;
    case "Winter":
        priceSeason = 2600;
        switch (isEven)
        {
            case false:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                }
                else
                {
                    price = priceSeason * 0.75;
                }
                break;
            default:
                if (fisherMen <= 6)
                {
                    price = priceSeason * 0.9;
                    price = price * 0.95;
                }
                else if (fisherMen > 7 && fisherMen <= 11)
                {
                    price = priceSeason * 0.85;
                    price = price * 0.95;

                }
                else
                {
                    price = priceSeason * 0.75;
                    price = price * 0.95;
                }
                break;
        }
        break;

}

if (budget > price)
{
    double leftMoney = budget - price;
    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
}
else
{
    double neededMoney = price - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
}