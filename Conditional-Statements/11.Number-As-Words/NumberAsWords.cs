using System;

class NumberAsWords
{
    static string[] _words =
     {
    "zero",  "eleven",
    "one",   "twelve",
    "two",   "thirteen",
    "three", "fourteen",
    "four",  "fifteen",
    "five",  "sixteen",
    "six",   "seventeen",
    "seven", "eighteen",
    "eight", "nineteen",
    "nine",
    "ten",
    };

    public static string GetString(int value)
    {
        if (value >= 0 &&
        value <= 19)
        {
            return _words[value];
        }
        return value.ToString();

        if(value >=20 && 99)
        {

        }
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine(NumberString.GetString(0));
        Console.WriteLine(NumberString.GetString(5));
        Console.WriteLine(NumberString.GetString(10));
        Console.WriteLine(NumberString.GetString(100));
    }


}

