using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        string timeOfDay = Console.ReadLine();
        DateTime dDate;
        DateTime noonBeer = DateTime.Parse("1:00 PM");
        DateTime morningBeer = DateTime.Parse("3:00 AM");

        if (DateTime.TryParseExact(timeOfDay, "h:mm tt", new CultureInfo("en-US"), DateTimeStyles.None, out dDate))
        {
          
            if (dDate >= noonBeer || dDate <= morningBeer)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}

