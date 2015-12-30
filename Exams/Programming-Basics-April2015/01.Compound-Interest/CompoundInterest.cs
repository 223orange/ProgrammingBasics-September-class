using System;
using System.Globalization;

class Program
{
    static void Main()
    {

    
        decimal price = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int years = int.Parse(Console.ReadLine());
        decimal bankIRate = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal friendIRate = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        decimal rate = (decimal)Math.Pow((double)(1 + bankIRate), (double)years);
        decimal bankValue = price * rate;
        decimal friendValue = price * (1 + friendIRate);

        if(bankValue<friendValue)
        {
            Console.WriteLine("{0:F2} Bank",bankValue);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendValue);
        }
    }
}   

