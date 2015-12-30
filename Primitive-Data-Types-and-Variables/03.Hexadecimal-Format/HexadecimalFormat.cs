using System;

class HexadecimalFormat
{
    static void Main()
    {
        int decValue = 254;
        string hexValue = decValue.ToString("X");

        Console.WriteLine(hexValue);
    }
}

