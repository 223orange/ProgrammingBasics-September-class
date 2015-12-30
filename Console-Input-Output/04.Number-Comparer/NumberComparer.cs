using System;
using System.Globalization;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double num = Math.Max(a, b);

        Console.WriteLine(num);
    }
}

