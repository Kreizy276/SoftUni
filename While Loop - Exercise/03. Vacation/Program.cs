double moneyNeeded = double.Parse(Console.ReadLine());
double moneyAvailable = double.Parse(Console.ReadLine());

int spent = 0;
int day = 0;
bool isSaved;

while (true)
{
    string action = Console.ReadLine();
    switch (action)
    {
        case "spend":
            double moneySpent = double.Parse(Console.ReadLine());
            moneyAvailable -= moneySpent;
            if(moneyAvailable < 0)
            {
                moneyAvailable = 0;
            }
            spent++;
            break;
        case "save":
            double moneySaved = double.Parse(Console.ReadLine());
            moneyAvailable += moneySaved;
            break;
    }

    day++;

    if(moneyAvailable >= moneyNeeded)
    {
        isSaved = true;
        break;
    }
    else if (spent == 5)
    {
        isSaved = false;
        break;
    }
    else
    {
        isSaved = false;
    }
}

if (isSaved)
{
    Console.WriteLine($"You saved the money for {day} days.");
}
else
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine($"{day}");
}