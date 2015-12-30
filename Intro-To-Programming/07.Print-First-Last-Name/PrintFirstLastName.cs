using System;

class PrintFirstLastName
{
    static void Main()
    {
        Console.WriteLine("Please provide your first name!");
        string first = Console.ReadLine();
        Console.WriteLine("Please provide your last name!");
        string last = Console.ReadLine();
        Console.WriteLine("Your full name is: {0} {1} ", first, last);
    }
}