int age = int.Parse(Console.ReadLine());
double priceLaundry = double.Parse(Console.ReadLine());
int priceToy = int.Parse(Console.ReadLine());

int sumMoney = 0;
int sumToys = 0;
int sumSoldToys = 0;
int brotherMoney = 0;
double money = 0;
int n = 0;

for(int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        n += 10;
        sumMoney += n;
        brotherMoney++;
    }
    else
    {
        sumToys++;
    }
}

sumSoldToys = sumToys * priceToy;
money = sumMoney + sumSoldToys - brotherMoney;

if(money >= priceLaundry)
{
    double leftMoney = money - priceLaundry;
    Console.WriteLine($"Yes! {leftMoney:f2}");
}
else
{
    double neededMoney = priceLaundry - money;
    Console.WriteLine($"No! {neededMoney:f2}");
}