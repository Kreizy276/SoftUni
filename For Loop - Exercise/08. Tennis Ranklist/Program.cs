int games = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

int win = 2000;
int finals = 1200;
int semiFinals = 720;
int averagePoints = 0;
int winCounter = 0;

for(int i = 1; i <= games; i++)
{
    string phase = Console.ReadLine();
    switch (phase)
    {
        case "W":
            startingPoints += win;
            averagePoints += win;
            winCounter++;
            break;
        case "F":
            startingPoints += finals;
            averagePoints += finals;
            break;
        case "SF":
            startingPoints += semiFinals;
            averagePoints += semiFinals;
            break;
    }
}

averagePoints /= games;
double wonGamesRatio = (double)winCounter / games * 100;

Console.WriteLine($"Final points: {startingPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{wonGamesRatio:f2}%");