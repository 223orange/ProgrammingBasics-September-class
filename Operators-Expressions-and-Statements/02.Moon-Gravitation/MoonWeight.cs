using System;

class MoonWeight
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;

        Console.WriteLine("The weight on the Moon will be {0} less.", moonWeight);
    }
}

