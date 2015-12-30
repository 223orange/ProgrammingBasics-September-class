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
        string numbers = Console.ReadLine();
        var array = Array.ConvertAll(numbers.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), Double.Parse);

        if (array.Length > 5)
        {
            Console.WriteLine("Please input only 5 numbers !!!");
        }
        else
        {
            for (int index = 0; index < array.Length; index++)
            {
                sum = array.Sum();
            }

            Console.WriteLine("The sum is : {0}", sum);
        }    
    }
}

