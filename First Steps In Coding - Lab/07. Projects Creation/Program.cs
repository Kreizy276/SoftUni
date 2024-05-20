string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int time = 3;
int neededTime = projects * time;

Console.WriteLine($"The architect {name} will need {neededTime} hours to complete {projects} project/s.");