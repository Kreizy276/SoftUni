// price = deposit price + deadline of deposit * ((deposit price * year interest rate) / 12)

double depositPrice = double.Parse(Console.ReadLine());
int deadline = int.Parse(Console.ReadLine());
double annualInterestRate =  double.Parse(Console.ReadLine());

double interestRate = depositPrice * (annualInterestRate / 100);
double monthlyInterest = interestRate / 12;
double finalPrice = depositPrice + deadline * monthlyInterest;

Console.WriteLine(finalPrice);