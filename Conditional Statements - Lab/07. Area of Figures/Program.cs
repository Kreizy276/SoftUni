string choice = Console.ReadLine();

if (choice == "square")
{
    double aS = double.Parse(Console.ReadLine());

    double result = aS * aS;
    Console.WriteLine($"{result:f3}");
}
else if (choice == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    double resultR = a * b;
    Console.WriteLine($"{resultR:f3}");
}
else if (choice == "circle")
{
    double r = double.Parse(Console.ReadLine());
    double resultC = r * r * Math.PI;

    Console.WriteLine($"{resultC:f3}");
}
else if (choice == "triangle")
{
    double side = double.Parse(Console.ReadLine()); 
    double height = double.Parse(Console.ReadLine());

    double resultT = side * height / 2;
    Console.WriteLine($"{resultT:f3}");
}