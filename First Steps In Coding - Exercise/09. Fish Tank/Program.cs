int cmLength = int.Parse(Console.ReadLine());
int cmWidth = int.Parse(Console.ReadLine());
int cmHeight = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = cmLength * cmWidth * cmHeight;
double converter = volume * 0.001;
double percent1 = percent / 100;
double litersFull = converter * (1 - percent1);

Console.WriteLine(litersFull);