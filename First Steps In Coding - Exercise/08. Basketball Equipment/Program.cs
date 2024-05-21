int priceTraining = int.Parse(Console.ReadLine());

double basketballShoes = priceTraining * 0.6;
double basketballTeam = basketballShoes * 0.8;
double basketballBall = basketballTeam * 0.25;
double basketballAccessories = basketballBall * 0.2;
double price = priceTraining + basketballShoes + basketballTeam + basketballBall + basketballAccessories;

Console.WriteLine(price);