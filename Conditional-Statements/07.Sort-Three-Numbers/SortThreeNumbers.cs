using System;
using System.Globalization;


class SortThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (a >= b && b >= c )
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
            if (a > b && b < c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }
        if (b >= a && a >= c)
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
            if (b >= a && a <= c)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        if (c >= a && a >= b)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
            if (c >= a && a <= b)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}

