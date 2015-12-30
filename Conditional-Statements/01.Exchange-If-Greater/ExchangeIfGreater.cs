using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double exsecondNum = secondNum;

        if (firstNum > secondNum)
        {
            secondNum = firstNum;
            Console.WriteLine("{0} {1}", exsecondNum, firstNum);
        }

        else
        {
            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }
       
    }
}

