using System;


class Program
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long packOfBeers = 0;
        long bottlesOfBeer = 0;
        long beers = 0;
      
            for (int i = 1; i <= rounds; i++)
            {
                long amountOfThieves = long.Parse(Console.ReadLine());
                long amountOfBeer = long.Parse(Console.ReadLine());

                if (amountOfThieves >= 5)
                {
                    thievesSlapped += 5;
                    thievesEscaped += (amountOfThieves - 5);
                }
                else
                {
                    thievesSlapped += amountOfThieves;
                    thievesEscaped += 0;
                }

                beers += amountOfBeer;
            }
            if (beers > 6)
            {
                packOfBeers = beers / 6;
                bottlesOfBeer = beers % 6;
            }
            else if (beers == 6)
            {
                packOfBeers = 1;
                bottlesOfBeer = 0;
            }
            else
            {
                packOfBeers = 0;
                bottlesOfBeer = beers;
            }
            Console.WriteLine("{0} thieves slapped.", thievesSlapped);
            Console.WriteLine("{0} thieves escaped.", thievesEscaped);
            Console.WriteLine("{0} packs, {1} bottles.", packOfBeers, bottlesOfBeer);
        }
}


