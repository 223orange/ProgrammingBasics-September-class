using System;
using System.Globalization;

class CircleRectangle
{
    static void Main()
    {

        Console.WriteLine("Please enter coordinates x and y ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       
        double circEqua = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2);
        
        if (circEqua < 2.25 && x < -1 || x > 5 && y < -1 || y > 1)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

