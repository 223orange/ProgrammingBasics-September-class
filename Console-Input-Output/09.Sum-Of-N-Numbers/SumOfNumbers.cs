using System;
using System.Threading;
using System.Globalization;
using System.Linq;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double sum = 0.0;
        
        Console.Write("Please enter a number !");
        int n = int.Parse(Console.ReadLine());
        string[] numbers = new string[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Console.ReadLine();
        }

        double[] doubleArray = new double[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            doubleArray[i] = Double.Parse(numbers[i]);
            sum = doubleArray.Sum();
        }

        Console.WriteLine(sum);
    }
}
