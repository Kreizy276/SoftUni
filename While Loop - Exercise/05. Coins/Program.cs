double change = double.Parse(Console.ReadLine());

int changeSum = (int)Math.Round(change * 100);
int coin = 0;

while (changeSum != 0)
{
    if (changeSum >= 200)
    {
        changeSum -= 200;
        coin++;
    }
    else if (changeSum >= 100)
    {
        changeSum -= 100;
        coin++;
    }
    else if (changeSum >= 50)
    {
        changeSum -= 50;
        coin++;
    }
    else if (changeSum >= 20)
    {
        changeSum -= 20;
        coin++;
    }
    else if (changeSum >= 10)
    {
        changeSum -= 10;
        coin++;
    }
    else if (changeSum >= 5)
    {
        changeSum -= 5;
        coin++;
    }
    else if (changeSum >= 2)
    {
        changeSum -= 2;
        coin++;
    }
    else if (changeSum >= 1)
    {
        changeSum -= 1;
        coin++;
    }
}

Console.WriteLine(coin);