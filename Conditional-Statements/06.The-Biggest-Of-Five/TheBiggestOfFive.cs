using System;
using System.Globalization;

class TheBiggestOfFive
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(d);
        }
        else if (e > a && e > b && e > c && e > d)
        {

            Console.WriteLine(e);
        }
        else
        {
            Console.WriteLine(a);
        }

    }
}

