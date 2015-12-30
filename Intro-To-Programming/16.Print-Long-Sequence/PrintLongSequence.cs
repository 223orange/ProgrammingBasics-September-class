using System;
using System.Collections.Generic;

class PrintLongSequence
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        // using for loop
        for (int i = 1; i < 16; i++)
        {
            int number = i % 2 == 0 ? i : -i;
            sequence.Add(number);
        }

        Console.WriteLine(string.Join(", ", sequence));
    }
}