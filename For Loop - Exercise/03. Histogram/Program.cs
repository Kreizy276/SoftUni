int n = int.Parse(Console.ReadLine());

int numbers = 0;
int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 1; i <= n; i++)
{
    numbers = int.Parse(Console.ReadLine());

    if(numbers < 200)
    {
        p1++;
    }
    else if (numbers >= 200 && numbers <= 399)
    {
        p2++;
    }
    else if (numbers >= 400 &&  numbers <= 599)
    {
        p3++;
    }
    else if (numbers >= 600 &&  numbers <= 799)
    {
        p4++;
    }
    else if (numbers >= 800)
    {
        p5++;
    }
}

double p1Perc = (double)p1 / n * 100;
double p2Perc = (double)p2 / n * 100;
double p3Perc = (double)p3 / n * 100;
double p4Perc = (double)p4 / n * 100;
double p5Perc = (double)p5 / n * 100;

Console.WriteLine($"{p1Perc:f2}%");
Console.WriteLine($"{p2Perc:f2}%");
Console.WriteLine($"{p3Perc:f2}%");
Console.WriteLine($"{p4Perc:f2}%");
Console.WriteLine($"{p5Perc:f2}%");