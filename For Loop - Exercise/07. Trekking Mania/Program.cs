int numClimber = int.Parse(Console.ReadLine());
int numGroups = 0;

int sumMusalla = 0;
int sumMountBlanc = 0;
int sumKilimanjaro = 0;
int sumK2 = 0;
int sumEverest = 0;
int sum = 0;

for(int i = 1; i <= numClimber; i++)
{

    numGroups = int.Parse(Console.ReadLine());

    if (numGroups <= 5 && numGroups > 0)
    {
        sumMusalla += numGroups;
    }
    else if (numGroups >= 6 && numGroups <= 12)
    {
        sumMountBlanc += numGroups;
    }
    else if (numGroups >= 13 && numGroups <= 25)
    {
        sumKilimanjaro += numGroups;
    }
    else if (numGroups >= 26 && numGroups <= 40)
    {
        sumK2 += numGroups;
    }
    else if (numGroups >= 41)
    {
        sumEverest += numGroups;
    }
    sum += numGroups;
}

double musalla = (double)sumMusalla / sum * 100;
double mountBlanc = (double)sumMountBlanc / sum * 100;
double kilimanjaro = (double)sumKilimanjaro / sum * 100;
double k2 = (double)sumK2 / sum * 100;
double everest = (double)sumEverest / sum * 100;

Console.WriteLine($"{musalla:f2}%");
Console.WriteLine($"{mountBlanc:f2}%");
Console.WriteLine($"{kilimanjaro:f2}%");
Console.WriteLine($"{k2:f2}%");
Console.WriteLine($"{everest:f2}%");