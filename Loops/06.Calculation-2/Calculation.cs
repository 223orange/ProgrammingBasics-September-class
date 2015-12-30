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
        int k = int.Parse(Console.ReadLine());
        
        int calc = CalcFac(n) / CalcFac(k);
        Console.WriteLine(calc);
    }
}

