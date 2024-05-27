double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string placeForVac = "";
double price = 0;

switch (season)
{
    case "summer":
        if (budget <= 100)
        {
            placeForVac = "Camp";
            destination = "Bulgaria";
            price = budget * 0.3;
        }
        else if (budget <= 1000 && budget > 100)
        {
            placeForVac = "Camp";
            destination = "Balkans";
            price = budget * 0.4;
        }
        else
        {
            placeForVac = "Hotel";
            destination = "Europe";
            price = budget * 0.9;
        }
        break;
    case "winter":
        placeForVac = "Hotel";
        if (budget <= 100)
        {
            destination = "Bulgaria";
            price = budget * 0.7;
        }
        else if (budget <= 1000 && budget > 100)
        {
            destination = "Balkans";
            price = budget * 0.8;
        }
        else
        {
            destination = "Europe";
            price = budget * 0.9;
        }
        break;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{placeForVac} - {price:f2}");