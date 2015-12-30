using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dividedNumber = n;
    
        if (n < 9999 && n > 999)
        {
            int fourthDigit = dividedNumber % 10;
            dividedNumber = dividedNumber / 10;
            int thirdDigit = dividedNumber % 10;
            dividedNumber = dividedNumber / 10;
            int secondDigit = dividedNumber % 10;
            dividedNumber = dividedNumber / 10;
            int firstDigit = dividedNumber % 10;
            if (firstDigit == 0)
            {
                Console.WriteLine("Please input a number which first digit is different than 0 !!!");
            }

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine("The sum of the 4 digits is: {0}  {4}{3}{2}{1} {4}{1}{2}{3} {1}{3}{2}{4}", sum, firstDigit, secondDigit, thirdDigit, fourthDigit);
        }
        else
        {
            Console.WriteLine("Please input a 4-diggit number !!!");
        }
    }
}

