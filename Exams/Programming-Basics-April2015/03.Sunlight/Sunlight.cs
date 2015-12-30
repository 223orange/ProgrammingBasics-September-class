using System;
using System.Linq;

class Sunlight
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int insidePart = (n * 3 - 1) / 2;
        Console.WriteLine("{0}*{0}", new string('.', insidePart));
        for (int  i = 1;  i < n;  i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (insidePart - 2)));
            insidePart--;
        }
        string body = new string('.', n) + new string('*', n) + new string('.', n) + Environment.NewLine;

        Console.Write(String.Concat(Enumerable.Repeat(body, n / 2)));

        Console.WriteLine(new string('*', n * 3));

        Console.Write(String.Concat(Enumerable.Repeat(body, n / 2)));

        for (int i = n-1; i >= 1; i--)
        {
            insidePart++;
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', (insidePart - 2)));
            
        }

        insidePart = (n * 3 - 1) / 2;

        Console.WriteLine("{0}*{0}", new string('.', insidePart));
    }
}

