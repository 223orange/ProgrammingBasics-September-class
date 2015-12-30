using System;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbersArray);
        foreach (int value in numbersArray)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
    }
}

