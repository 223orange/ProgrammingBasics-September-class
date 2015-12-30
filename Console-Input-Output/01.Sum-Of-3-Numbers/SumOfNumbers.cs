using System;

class SumOfNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;

        Console.WriteLine("Th sum of a, b and c is: {0}", sum);
    }
}

