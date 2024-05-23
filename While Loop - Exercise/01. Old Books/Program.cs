string input = Console.ReadLine();
string book = "";

int counter = 0;

while (book != "No More Books")
{
    book = Console.ReadLine();
    if(book != input)
    {
        counter++;
    }
    else
    {
        break;
    }
}

if(book == "No More Books")
{
    counter--;
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {counter} books.");
}
else if (input == book)
{
    Console.WriteLine($"You checked {counter} books and found it.");
}