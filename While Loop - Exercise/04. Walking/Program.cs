int stepsGoal = 10000;

int goal = 0;
int currentSteps = 0;

while (goal <= stepsGoal)
{
    string command = Console.ReadLine();
    if(command != "Going home")
    {
        currentSteps = int.Parse(command);
        goal += currentSteps;
    }
    else
    {
        command = Console.ReadLine();
        currentSteps = int.Parse(command);
        goal += currentSteps;
        break;
    }
}

if (goal >= stepsGoal)
{
    int leftOverSteps = goal - stepsGoal;
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{leftOverSteps} steps over the goal!");
}
else 
{
    int neededSteps = stepsGoal - goal;
    Console.WriteLine($"{neededSteps} more steps to reach goal.");
}