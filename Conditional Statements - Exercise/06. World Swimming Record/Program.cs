double recordSec = double.Parse(Console.ReadLine());
double distanceM = double.Parse(Console.ReadLine());
double record1MSec = double.Parse(Console.ReadLine());

double timeNeeded = 0.0;
double distanceNeeded = distanceM * record1MSec;

double distanceSlowed = Math.Floor(distanceM / 15);
double timeSlowed = distanceSlowed * 12.5;
double time = distanceNeeded + timeSlowed;

if (recordSec < time)
{
    timeNeeded = time - recordSec;
    Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
}
else
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
}