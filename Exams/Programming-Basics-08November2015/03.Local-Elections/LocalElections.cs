using System;

class LocalElections
{
    static void Main()
    {
        int numberOfCandidates = int.Parse(Console.ReadLine());
        int voteElector = int.Parse(Console.ReadLine());
        char votingSymbol = char.Parse(Console.ReadLine());

        Console.WriteLine(new string('.',13));


        for (int counter = 1; counter <= numberOfCandidates; counter++)
        {
            if (voteElector == counter)
            {
                CellPrintVote(counter, votingSymbol);
                Console.WriteLine(new string('.', 13));
            }
            else
            {
                CellPrint(counter);
                Console.WriteLine(new string('.', 13));
            }
        }
    }
    static void CellPrint(int counter)
    {
        Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
        for (int i = 1; i < 4; i++)
        {
            if (counter >= 10 && i == 2)
            {
                Console.WriteLine("{0}.|{1}|{2}", counter, new string('.', 5), new string('.', 3));

            }

            else if (i == 2)
            {
                Console.WriteLine("0{0}.|{1}|{2}", counter, new string('.', 5), new string('.', 3));

            }
            else
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
            }
    
                
        }
        Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
    }
    static void CellPrintVote(int counter, char votingSymbol)
    {
        if (votingSymbol == 'x' || votingSymbol == 'X')
        {
            if (counter >= 10)
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|{1}\\{1}/{1}|{0}", new string('.', 3), new string('.', 1));
                Console.WriteLine("{0}.|{1}X{1}|{2}", counter, new string('.', 2), new string('.', 3));
                Console.WriteLine("{0}|{1}/{1}\\{1}|{0}", new string('.', 3), new string('.', 1));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));

            }
            else
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|{1}\\{1}/{1}|{0}", new string('.', 3), new string('.', 1));
                Console.WriteLine("0{0}.|{1}X{1}|{2}", counter, new string('.', 2), new string('.', 3));
                Console.WriteLine("{0}|{1}/{1}\\{1}|{0}", new string('.', 3), new string('.', 1));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));

            }

        }

        else if (votingSymbol == 'v' || votingSymbol == 'V')
        {
            if (counter >= 10)
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|\\{0}/|{0}", new string('.', 3));
                Console.WriteLine("{0}{1}|{1}\\{1}/{1}|{2}", counter, new string('.', 1), new string('.', 3));
                Console.WriteLine("{0}|{1}V{1}|{0}", new string('.', 3), new string('.', 2));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
            else
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|\\{0}/|{0}", new string('.', 3));
                Console.WriteLine("0{0}{1}|{1}\\{1}/{1}|{2}", counter, new string('.', 1), new string('.', 3));
                Console.WriteLine("{0}|{1}V{1}|{0}", new string('.', 3), new string('.', 2));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
        }
    }
}


