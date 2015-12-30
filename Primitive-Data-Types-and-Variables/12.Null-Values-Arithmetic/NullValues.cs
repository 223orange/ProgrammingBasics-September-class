using System;

class NullValues
{
    static void Main()
    {
        int? numvalue1 = null;
        double? numvalue2 = null;

        numvalue1 = 10 + 5;
        numvalue2 = numvalue1 * 10;

        Console.WriteLine(numvalue1);
        Console.WriteLine(numvalue2);
    }
}

