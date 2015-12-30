using System;
using System.Globalization;

class ComparingFloats
{
    static void Main()
    {
        double double1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double double2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double eps = .000001;

        if (Math.Abs(double1 - double2) <= eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}







