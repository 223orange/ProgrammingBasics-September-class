using System;


class ExchangeBits
{

    static void Main()
    {

        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint[] Array = new uint[33];

        int counter = q;
        uint result = 0;

        if (p < p + k - 1 && q < q + k - 1 && p < q)
        {
            if(p+k-1 < q)
                {

                for (int i = 0; i < 32; i++)
                {
                    uint digitNum = n;
                    uint nRight = digitNum >> i;
                    Array[i] = nRight & 1;
                }
                for (int i = p; i <= p + k - 1; i++)
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
                counter = p;
                for (int i = q; i <= q + k - 1; i++)
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
            else
            {
                Console.WriteLine("overlapping");
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

