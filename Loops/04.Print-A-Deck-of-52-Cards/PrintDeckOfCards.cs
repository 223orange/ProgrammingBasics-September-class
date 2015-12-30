using System;

class PrintDeckOfCards
{
    static void Main()
    {
        int hearts = 3;
        int diamonds = 4;
        int clubs = 5;
        int spades = 6;
      
        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine(" " + ((char)hearts) + i + " " + ((char)diamonds) + i + " " + ((char)clubs) + i + " " + ((char)spades) + i);

            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine(" " + (char)hearts + "D " + (char)diamonds + "D " + ((char)clubs) + "D " + ((char)spades) + "D "); break;
                        case 12: Console.WriteLine(" " + (char)hearts + "A " + (char)diamonds + "A " + (char)clubs + "A " + ((char)spades) + "A "); break;
                        case 13: Console.WriteLine(" " + (char)hearts + "J " + (char)diamonds + "J " + (char)clubs + "J " + ((char)spades) + "J "); break;
                        case 14: Console.WriteLine(" " + (char)hearts + "K " + (char)diamonds + "K " + (char)clubs + "K " + ((char)spades) + "K "); break;
                    }
            }
        }
    }
}

