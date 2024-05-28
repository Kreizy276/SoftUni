string nameActor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());

double sum = 0;

for(int i = 1; i <= judges; i++)
{
    string nameJudge = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    int length = nameJudge.Length;
    sum = length * judgePoints / 2;
    points += sum;

    if(points > 1250.0)
    {
        Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {points:f1}!");
        break;
    }
}

if(points < 1250.5)
{
    double neededPoints = 1250.5 - points;
    Console.WriteLine($"Sorry, {nameActor} you need {neededPoints:f1} more!");
}