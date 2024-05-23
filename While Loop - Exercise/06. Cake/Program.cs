int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int area = a * b;
int cake = area;
string input = "";
int piecesTaken = 0;
//int cakeSum = 0;
bool isCakeLeft = true;

while (cake >= 0)
{
    input = Console.ReadLine();
    if(input != "STOP")
    {
        piecesTaken = int.Parse(input);
        //cakeSum += piecesTaken;
        cake -= piecesTaken;
        isCakeLeft = false;
    }
    else
    {
        isCakeLeft = true;
        break;
    }
}

if (isCakeLeft)
{
    Console.WriteLine($"{cake} pieces are left.");
}
else
{
    int neededPieces = Math.Abs(cake);
    //int neededPieces = cakeSum - area;
    Console.WriteLine($"No more cake left! You need {neededPieces} pieces more.");
}