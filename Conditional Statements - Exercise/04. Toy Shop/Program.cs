double priceEx = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls =  int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double sum = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2; 
int toys = puzzles + dolls + bears + minions + trucks;
double discount = 0.0;
double finalPrice = 0.0;
double rent = 0.0;
double income = 0.0;


if (toys >= 50)
{
    discount = sum * 0.25;
    
}

finalPrice = sum - discount;
rent = finalPrice * 0.1;
income = finalPrice - rent;

if (income > priceEx)
{
    double leftMoney = income - priceEx;
    Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
}
else if (income < priceEx)
{
    double moneyNeeded = priceEx - income;
    Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed."); 
}
