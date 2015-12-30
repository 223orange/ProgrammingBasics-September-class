using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 1 == 0 || n % n == 0)
        {
            if (n == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
            
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

