using System;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    static void Main()

    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("The equation is not quadratic !");

        }

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {1}{0}x2 = {2}", Environment.NewLine, x1, x2);
        }
        if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1=x2= {0:F2}", x);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

