string fruit = Console.ReadLine();
string weekday = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;
bool invalidInput = false;

switch (weekday)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                price = quantity * 2.5;
                break;
            case "apple":
                price = quantity * 1.2;
                break;
            case "orange":
                price = quantity * 0.85;
                break;
            case "grapefruit":
                price = quantity * 1.45;
                break;
            case "kiwi":
                price = quantity * 2.7;
                break;
            case "pineapple":
                price = quantity * 5.5;
                break;
            case "grapes":
                price = quantity * 3.85;
                break;
            default:
                invalidInput = true;
                break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                price = quantity * 2.7;
                break;
            case "apple":
                price = quantity * 1.25;
                break;
            case "orange":
                price = quantity * 0.9;
                break;
            case "grapefruit":
                price = quantity * 1.60;
                break;
            case "kiwi":
                price = quantity * 3;
                break;
            case "pineapple":
                price = quantity * 5.6;
                break;
            case "grapes":
                price = quantity * 4.2;
                break;
            default:
                invalidInput = true;
                break;
        }
        break;
    default:
        invalidInput = true;
        break;

}

if (invalidInput)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine($"{price:f2}");
}