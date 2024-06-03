string input = Console.ReadLine();

while (input != "End")
{
    string destination = input;
    double budget = double.Parse(Console.ReadLine());

    double money = 0;
    double savings = 0;
    while (money < budget)
    {
        money += double.Parse(Console.ReadLine());
    }

    Console.WriteLine($"Going to {destination}!");

    input = Console.ReadLine();
}