double area = 7.61;
double discount = 18;

double areaNeeded = double.Parse(Console.ReadLine());

double price = areaNeeded * area;
double discountPrice = price * (discount / 100);
double finalPrice = price - discountPrice;

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discountPrice} lv.");