double nylon = 1.5;
double paint = 14.5;
double painter = 5.00;
double bag = 0.4;

int nylons = int.Parse(Console.ReadLine());
int amountPaint =  int.Parse(Console.ReadLine());
int amountPainters =  int.Parse(Console.ReadLine());
int time = int.Parse(Console.ReadLine());

double priceNylon = (nylons + 2) * nylon;
double pricePaint = amountPaint * 1.1 * paint;
double pricePainters = amountPainters * painter;

Console.WriteLine("-------");

double finalPrice = priceNylon + pricePaint + pricePainters + bag;
double priceWorkers = (finalPrice * 0.3) * time;
double finalFinalPrice = finalPrice + priceWorkers;

Console.WriteLine(finalFinalPrice);