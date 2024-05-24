double budget = double.Parse(Console.ReadLine());
int GPUs = int.Parse(Console.ReadLine());
int CPUs = int.Parse(Console.ReadLine());
int RAM = int.Parse(Console.ReadLine());

double price = 0.0;
double priceAll = 0.0;

double gpuPrice = GPUs * 250;
double cpuPriceFor1 = gpuPrice * 0.35;
double cpuPrice = CPUs * cpuPriceFor1;
double ramPriceFor1 = gpuPrice * 0.1;
double ramPrice = RAM * ramPriceFor1;


if (GPUs > CPUs)
{
    priceAll = gpuPrice + cpuPrice + ramPrice;
    price = priceAll * 0.85;
}
else
{
    price = gpuPrice + cpuPrice + ramPrice;
}
if (price <= budget)
{
    double leftMoney = budget - price;
    Console.WriteLine($"You have {leftMoney:f2} leva left!");
}
else
{
    double neededMoney = price - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
}