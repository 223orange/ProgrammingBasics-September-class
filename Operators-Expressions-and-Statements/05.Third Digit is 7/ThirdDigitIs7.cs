using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dividedNumber = n;
        int counter = 0;
        while (n != 0)
        {
            int theDigit = dividedNumber % 10;
            dividedNumber = dividedNumber / 10;
            counter++;
            if (theDigit == 7 && counter == 3)
            {
                Console.WriteLine("true");
                break;
            }
            if (counter > 3)
            {
                Console.WriteLine("false");
                break;
            }
        }
    } 
}

