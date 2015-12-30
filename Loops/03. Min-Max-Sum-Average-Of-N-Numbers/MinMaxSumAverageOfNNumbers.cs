using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arrNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = arrNumbers[0];
        int max = arrNumbers[0];
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arrNumbers[i];
            if (min > arrNumbers[i])
                min = arrNumbers[i];
            if (max < arrNumbers[i])
                max = arrNumbers[i];
        }
        average = (double)sum / n;

        Console.WriteLine();
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0,2:n}", average);

    }
}

