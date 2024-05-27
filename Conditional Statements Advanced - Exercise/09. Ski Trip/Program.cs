int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string evaluation = Console.ReadLine();

//	"room for one person" – 18.00 лв за нощувка
//	"apartment" – 25.00 лв за нощувка 
//	"president apartment" – 35.00 лв за нощувка

double price = 0;
days -= 1;

switch (roomType)
{
    case "room for one person":

        price = days * 18;

        switch (evaluation)
        {
            case "positive":
                price *= 1.25;
                break;
            case "negative":
                price *= 0.9;
                break;
        }
        break;
    case "apartment":

        price = days * 25;

        if (days < 10)
        {
            price *= 0.7;
        }
        else if (days > 10 && days < 15)
        {
            price *= 0.65;
        }
        else if (days > 15)
        {
            price *= 0.5;
        }
        switch (evaluation)
        {
            case "positive":
                price *= 1.25;
                break;
            case "negative":
                price *= 0.9;
                break;
        }
        break;
    case "president apartment":

        price = days * 35;

        if (days < 10)
        {
            price *= 0.9;
        }
        else if (days > 10 && days < 15)
        {
            price *= 0.85;
        }
        else if (days > 15)
        {
            price *= 0.8;
        }
        switch (evaluation)
        {
            case "positive":
                price *= 1.25;
                break;
            case "negative":
                price *= 0.9;
                break;
        }
        break;
}

Console.WriteLine($"{price:f2}");