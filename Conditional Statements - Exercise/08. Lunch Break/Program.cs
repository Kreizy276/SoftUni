string serialFilm = Console.ReadLine();
int epTime = int.Parse(Console.ReadLine());
int breakTime = int.Parse(Console.ReadLine());

double timeLunch = breakTime / 8.0;
double timeBreak = breakTime / 4.0;
double timeLeft = breakTime - timeLunch - timeBreak;
double difference = Math.Abs(timeLeft - epTime);

if (timeLeft >= epTime)
{
    Console.WriteLine($"You have enough time to watch {serialFilm} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {serialFilm}, you need {Math.Ceiling(difference)} more minutes.");
}