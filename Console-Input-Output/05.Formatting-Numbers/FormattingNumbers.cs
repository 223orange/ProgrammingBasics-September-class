using System;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        string binary = Convert.ToString(a, 2).PadLeft(10,'0');

        Console.WriteLine("|{0,-10:X}|{1,10:00}|{2,10:F2}|{3,-10:F3}|", a, binary, b, c);
    }
}

