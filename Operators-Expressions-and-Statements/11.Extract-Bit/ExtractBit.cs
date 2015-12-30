using System;

class ExtractBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nRight = n >> 3;
        int bit = nRight & 1;

        Console.WriteLine(bit);
    }
}

