double dog = 2.5;
double cat = 4;

int dogFood = int.Parse(Console.ReadLine());
int catFood =  int.Parse(Console.ReadLine());

double priceDog = dogFood * dog;
double priceCat = catFood * cat;

double finalPrice = priceDog + priceCat;

Console.WriteLine($"{finalPrice} lv.");
