using System;
using System.Text;
using System.Numerics;

class PetarsGame
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong m = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();
        BigInteger sum = 0;
        string replacedChar;

        for (ulong i = n; i < m; i++)
        {
            if (i % 5 == 0)
            {
                sum += i;
            }
            else
            {
                sum += (i % 5);
            }
        }
        string result = Convert.ToString(sum);
        if (sum % 2 == 0)
        {
             replacedChar = Convert.ToString(result[0]);
        }
        else
        {
            replacedChar = Convert.ToString(result[result.Length -1]);
        }
        result = result.Replace(replacedChar, replacement);
        Console.WriteLine(result);
    }
}

