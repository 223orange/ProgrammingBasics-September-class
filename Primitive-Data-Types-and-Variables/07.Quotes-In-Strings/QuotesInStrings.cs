using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstoption= "the \"use\" of quotations causes difficulties";
        string secondoption = @"the ""use"" of quotations causes difficulties";

        Console.WriteLine(firstoption);
        Console.WriteLine(secondoption);
    }
}
