int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());

int examTime = examHour * 60 + examMinute;
int arrivalTime = arrivalHour * 60 + arrivalMinute;

if (arrivalTime > examTime)
{

    Console.WriteLine("Late");
    int minutesLate = arrivalTime - examTime;
    int hour = minutesLate / 60;
    int minute = minutesLate % 60;
    
    if (minutesLate < 60)
    {   
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{hour}:{minute:d2} hours after the start");
    }
}
else if (examTime - arrivalTime <= 30)
{

    int minutesOnTime = examTime - arrivalTime;
    if(minutesOnTime != 0)
    {    
        Console.WriteLine("On time");
        Console.WriteLine($"{minutesOnTime} minutes before the start");
    }
    else
    {
        Console.WriteLine("On time");
    }
}
else
{

    Console.WriteLine("Early");
    int minutesEarly = examTime - arrivalTime;
    int hour = minutesEarly / 60;
    int minute = minutesEarly % 60;

    if(minute < 60 && hour >= 1)
    {
        Console.WriteLine($"{hour}:{minute:d2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{minutesEarly} minutes before the start");
    }
}
