using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if(score>= 1 && score <= 3)
        {
            int result = score * 10;
            Console.WriteLine(result);
        }
        if (score >= 4 && score <= 6)
        {
            int result = score * 100;
            Console.WriteLine(result);
        }
        if (score >= 7 && score <= 9)
        {
            int result = score * 1000;
            Console.WriteLine(result);
        }
        if (score == 0 && score > 9)
        {
            int result = 0;
            Console.WriteLine(result);
        }
    }
}

