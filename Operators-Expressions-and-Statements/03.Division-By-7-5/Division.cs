using System;

class Division
{
    static void Main()
    {
        Console.Write("Please enter a number ! ");
        int n = int.Parse(Console.ReadLine());
        if (n % 5 == 0 || n % 7 == 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

