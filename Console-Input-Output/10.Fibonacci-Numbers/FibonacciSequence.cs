using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Please enter a number ! ");
        int n = int.Parse(Console.ReadLine());

        int fibFirst = 0;
        int fibSecond = 1;
        
        Console.Write(fibFirst);

        for (int i = 1; i < n; i++)
        {
            fibSecond = fibFirst + fibSecond;
            fibFirst = fibSecond - fibFirst;

            Console.Write(" {0}",fibFirst);
        }
        Console.WriteLine();
    }
}