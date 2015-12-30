using System;

class Calculation
{
    static int CalcFac(int j)
    {
        if (j < 2)
        {
            return 1;
        }
        return j * CalcFac(j - 1);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double calc = 1;
        for (int i = 1; i <= n; i++)
        {
           calc = calc + CalcFac(i) / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}", calc);
    }
}

