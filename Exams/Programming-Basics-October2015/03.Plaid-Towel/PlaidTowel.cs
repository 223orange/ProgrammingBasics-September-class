using System;

class PlaidTowel
{
    static void UpperPart(int n, char backgroundSymbol, char rombusSymbol)
    {
        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(backgroundSymbol, n - i), rombusSymbol, new string(backgroundSymbol, 2 * i - 1), new string(backgroundSymbol, ((2 * n - 1) - (2 * i))));
        }
    }
    static void LowerPart(int n, char backgroundSymbol, char rombusSymbol)
    {
        for (int i = n - 1; i >= 1; i--)
        {

            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(backgroundSymbol, n - i), rombusSymbol, new string(backgroundSymbol, 2 * i - 1), new string(backgroundSymbol, ((2 * n - 1) - (2 * i))));
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char backgroundSymbol = char.Parse(Console.ReadLine());
        char rombusSymbol = char.Parse(Console.ReadLine());

        
        Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, n), rombusSymbol, new string(backgroundSymbol, (2 * n - 1)));

        UpperPart(n,backgroundSymbol,rombusSymbol);

        Console.WriteLine("{0}{1}{0}{1}{0}", rombusSymbol, new string(backgroundSymbol, 2 * n - 1), rombusSymbol);

        LowerPart(n,backgroundSymbol,rombusSymbol);

        Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, n), rombusSymbol, new string(backgroundSymbol, (2 * n - 1)));

        UpperPart(n, backgroundSymbol, rombusSymbol);

        Console.WriteLine("{0}{1}{0}{1}{0}", rombusSymbol, new string(backgroundSymbol, 2 * n - 1), rombusSymbol);

        LowerPart(n, backgroundSymbol, rombusSymbol);

        Console.WriteLine("{0}{1}{2}{1}{0}", new string(backgroundSymbol, n), rombusSymbol, new string(backgroundSymbol, (2 * n - 1)));
    }
}

