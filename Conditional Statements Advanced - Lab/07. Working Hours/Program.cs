int time = int.Parse(Console.ReadLine());
string weekday = Console.ReadLine();

bool work = time >= 10 && time <= 18;

switch (weekday)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        if(work == true)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("closed");
        break;
}