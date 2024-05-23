int threshold = int.Parse(Console.ReadLine());

string input = "";
int problem = 0;
int sum = 0;
int mistake = 0;
string lastName = "";
int grade = 0;
double average = 0;

while (true)
{
    input = Console.ReadLine();
    if (input != "Enough")
    {
        lastName = input;
        grade = int.Parse(Console.ReadLine());
        sum += grade;
        problem++;
        if (grade <= 4)
        {
            mistake++;
        }
        if (mistake == threshold)
        {
            break;
        }
    }
    else if (input == "Enough")
    {
        break;
    }
}

if (input == "Enough")
{
    average = (double)sum / problem;
    Console.WriteLine($"Average score: {average:f2}");
    Console.WriteLine($"Number of problems: {problem}");
    Console.WriteLine($"Last problem: {lastName}");
}
else if (mistake == threshold)
{
    Console.WriteLine($"You need a break, {mistake} poor grades.");
}