using System;

class ExtractBitInt

{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the position");
        int p = int.Parse(Console.ReadLine());
        int nRight = n >> p;
        int bit = nRight & 1;

        if (bit == 1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}



