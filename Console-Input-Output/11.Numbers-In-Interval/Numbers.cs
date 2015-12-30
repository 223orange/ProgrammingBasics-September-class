using System;
using System.Collections.Generic;

class Numbers
{
    static void Main()
    {
        Console.Write("Please inter the first number from the interval ! ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Please enter the last number from the interval ! ");
        int n = int.Parse(Console.ReadLine());
        
        int counter = 0;
        int value = 0;
        List<int> numbers = new List<int>();

        for (value = m; value <= n; value++)
        {
            if (value % 5 == 0)
            {
                numbers.Add(value);
                counter++;
            }
        }
        Console.WriteLine(counter);
        for(int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
