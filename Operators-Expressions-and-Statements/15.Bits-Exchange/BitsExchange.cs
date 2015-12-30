using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint[] Array = new uint[28];
      
        int counter = 24;
        uint result = 0;


        for (int i = 0; i < 28; i++)
        {
            uint digitNum = n;
            uint nRight = digitNum >> i;
            Array[i] = nRight & 1;
        }
        for (int i = 3; i <= 5; i++)
        {
            if(Array[i] == 0)
            {
                int mask = ~(1 << counter);
                result = (uint)n & (uint)mask;
                n = result;
                counter++;
            }
            if (Array[i] == 1)
            {
                int mask = 1 << counter;
                result = (uint)n | (uint)mask;
                n = result;
                counter++;
            }
        }
        counter = 3;
        for (int i = 24; i <= 26; i++)
        {
            if (Array[i] == 0)
            {
                int mask = ~(1 << counter);
                result = (uint)n & (uint)mask;
                n = result;
                counter++;
            }
            if (Array[i] == 1)
            {
                int mask = 1 << counter;
                result = (uint)n | (uint)mask;
                n = result;
                counter++;
            }

        }

        Console.WriteLine(result);
    }
}

