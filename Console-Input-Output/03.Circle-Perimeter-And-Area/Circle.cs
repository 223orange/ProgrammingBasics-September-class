using System;
using System.Globalization;

class Circle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double Pi = Math.PI;

        double param = 2 * Pi * radius;
        double area = Pi * radius * radius;

        Console.WriteLine("Perimeter: {1:0.00}{0}Area:{2:0.00}{0}", Environment.NewLine, param, area);
    }
}

