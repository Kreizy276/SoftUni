string month = Console.ReadLine();
int sleepover = int.Parse(Console.ReadLine());

//Май и октомври ; Юни и септември ; Юли и август
//Студио – 50 лв./нощувка ; Студио – 75.20 лв./нощувка ; Студио – 76 лв./нощувка
//Апартамент – 65 лв./нощувка ; Апартамент – 68.70 лв./нощувка ; Апартамент – 77 лв./нощувка

//•	За студио, при повече от 7 нощувки през май и октомври : 5 % намаление.
//•	За студио, при повече от 14 нощувки през май и октомври : 30 % намаление.
//•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
//•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

double priceStudio = 0;
double priceApartment = 0;
double studio = 0;
double apartment = 0;

switch (month)
{
    case "May":
    case "October":

        apartment = 65;
        studio = 50;
        if (sleepover > 7 && sleepover < 14)
        {
            priceStudio = sleepover * studio * 0.95;
            priceApartment = sleepover * apartment;
        }
        else if (sleepover > 14)
        {
            priceStudio = sleepover * studio * 0.7;
            priceApartment = sleepover * apartment * 0.9;
        }
        else
        {
            priceStudio = sleepover * studio;
            priceApartment = sleepover * apartment;
        }
        break;
    case "June":
    case "September":

        studio = 75.20;
        apartment = 68.70;
        if (sleepover > 14)
        {
            priceStudio = sleepover * studio * 0.8;
            priceApartment = sleepover * apartment * 0.9;
        }
        else
        {
            priceStudio = sleepover * studio;
            priceApartment = sleepover * apartment;
        }
        break;
    case "July":
    case "August":

        studio = 76;
        apartment = 77;

        if(sleepover > 14)
        {
            priceStudio = sleepover * studio;
            priceApartment = sleepover * apartment * 0.9;
        }
        else
        {
            priceStudio = sleepover * studio;
            priceApartment = sleepover * apartment;
        }
        break;
}

Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
Console.WriteLine($"Studio: {priceStudio:f2} lv.");