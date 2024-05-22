string name = Console.ReadLine();

double average = 0;
int counter = 0;
int mistake = 0;

while (true)
{
    double grades = double.Parse(Console.ReadLine());
    average += grades;
    counter++;
    
    if (grades >= 4 && counter < 12 && mistake < 2)
    {
        continue;
    }
    else if (counter == 12)
    {
        break;
    }
    else
    {
        mistake++;
    }
    if(mistake == 2)
    {
        break;
    }
}

if (counter == 12)
{
    average /= 12;
    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
}
else if (mistake == 2)
{
    counter--;
    Console.WriteLine($"{name} has been excluded at {counter} grade");
}