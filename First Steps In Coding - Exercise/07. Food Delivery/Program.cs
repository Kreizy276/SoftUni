double chickenMenu = 10.35;
double fishMenu = 12.4;
double veganMenu = 8.15;
int percent = 20;
double delivery = 2.5;

int chickenNum = int.Parse(Console.ReadLine());
int fishNum = int.Parse(Console.ReadLine());
int veganNum = int.Parse(Console.ReadLine());

double chickenPrice = chickenNum * chickenMenu;
double fishPrice = fishNum * fishMenu;
double veganPrice = veganNum * veganMenu;

double finalPrice = chickenPrice + fishPrice + veganPrice;
double dessertPrice = finalPrice * percent / 100;
double finalFinalPrice = dessertPrice + delivery + finalPrice;

Console.WriteLine(finalFinalPrice);
