int countPages = int.Parse(Console.ReadLine());
int pagesHour = int.Parse(Console.ReadLine());
int days =  int.Parse(Console.ReadLine());

int time = countPages / pagesHour;
int neededTime = time / days;

Console.WriteLine(neededTime);