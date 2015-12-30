using System;
using System.Globalization;

class PointInaCircle
{
    static void Main()
    {

        Console.WriteLine("Please enter coordinates x and y ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circEqua = Math.Pow(x, 2) + Math.Pow(y,2);

        if (circEqua < 4)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

