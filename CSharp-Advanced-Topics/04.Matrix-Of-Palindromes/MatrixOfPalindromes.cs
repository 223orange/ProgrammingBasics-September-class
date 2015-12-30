using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        char firstLetter = 'a';
        for (char i = 'a'; i <= firstLetter + rows - 1; i++)
        {
            for (char j = i; j < i + columns; j++)
            {
                string letters = i.ToString() + j.ToString() + i.ToString();
                Console.Write("{0} ", letters);
            }
            Console.WriteLine();
        }
    }
}


