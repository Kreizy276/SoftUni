double pen = 5.8;
double marker = 7.2;
double preparat = 1.2; // for liter

int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int preparats = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

double pricePen = pens * pen;
double priceMarker = markers * marker;
double pricePreparat = preparats * preparat;
double finalPrice = pricePen + priceMarker + pricePreparat;
double discountPrice = finalPrice - finalPrice * (discount / 100);
Console.WriteLine("--------");

Console.WriteLine(discountPrice);