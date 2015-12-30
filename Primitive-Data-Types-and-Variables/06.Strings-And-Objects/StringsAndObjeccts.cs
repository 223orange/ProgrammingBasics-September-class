using System;

class StringsAndObjeccts
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object container = first+" "+ second;
        string third = (string)container;

        Console.WriteLine(third);
    }
}

