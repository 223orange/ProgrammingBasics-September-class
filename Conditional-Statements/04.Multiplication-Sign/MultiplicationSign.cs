using System;
using System.Globalization;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("-");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if (a < 0 && b < 0 || a < 0 && c < 0 || b < 0 && c < 0)
        {
            Console.WriteLine("+");
        }
        else if (a < 0 || b < 0 || c < 0)
        {
            Console.WriteLine("-");
        }
    }
}

