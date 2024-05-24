double budget = double.Parse(Console.ReadLine());
int statics =  int.Parse(Console.ReadLine());
double costume = double.Parse(Console.ReadLine());

double decorPrice = budget * 0.1;
double costumePrice = 0.0;
double filmPrice = 0.0;
double discountPrice = 0.0;
double finalPriceCostume = 0.0;
double finalFinalPrice = 0.0;

if (statics >= 150)
{
    costumePrice = statics * costume;
    discountPrice = costumePrice * 0.1;
    finalPriceCostume = costumePrice - discountPrice;
    filmPrice = decorPrice + finalPriceCostume;
}
else
{
    costumePrice = statics * costume;
    filmPrice = decorPrice + costumePrice;
}



if(filmPrice > budget)
{
    double neededMoney = filmPrice - budget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
}
else if (filmPrice <= budget)
{
    double leftMoney = budget - filmPrice;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
}
