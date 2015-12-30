using System;
using System.Collections.Generic;

class PrintSequence
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        // using for loop
        for (int i = 2; i < 12; i++)
        {
            int number = i % 2 == 0 ? i : -i;
            sequence.Add(number);
        }

        Console.WriteLine(string.Join(", ", sequence));
    }
}

