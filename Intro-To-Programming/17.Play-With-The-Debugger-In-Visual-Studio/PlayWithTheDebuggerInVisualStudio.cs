using System;
using System.Collections.Generic;

class PlayWithTheDevuggerInVisualStudio
{
    static void Main()
    {
        List<int> sequence = new List<int>();
        // using for loop
        for (int i = 2; i < 1001; i++)
        {
            int number = i;
            sequence.Add(number);
        }

        Console.WriteLine(string.Join(Environment.NewLine, sequence));
    }
}
