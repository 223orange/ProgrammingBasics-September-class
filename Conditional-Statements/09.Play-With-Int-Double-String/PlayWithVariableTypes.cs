using System;
using System.Globalization;

class PlayWithVariableTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string type = Console.ReadLine();
        switch (type)
        {
            case "1":
                Console.WriteLine("Please enter an int: ");
                int numInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numInt + 1);
                break;
            case "2":
                Console.WriteLine("Please enter a double: ");
                double numDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(numDouble + 1);
                break;
            case "3":
                Console.WriteLine("Please enter a string: ");
                string strText = Console.ReadLine();
                Console.WriteLine("*{0}", strText);
                break;
        }
    }
}

