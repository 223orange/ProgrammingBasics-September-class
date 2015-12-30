using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = (double)(a + b) / 2 * h;

        Console.WriteLine("The area of the Trapezoid is : {0} ", area);
    }
}

