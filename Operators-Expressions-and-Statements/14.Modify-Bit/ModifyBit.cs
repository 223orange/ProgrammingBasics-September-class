using System;


class ModifyBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please input the position ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a value : 0 or 1 ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;

            Console.WriteLine(result);
        }
        if (v == 1)
        {
            int mask = 1 << p;
            int bit = n | mask;

            Console.WriteLine(bit);
        }
    }
}

