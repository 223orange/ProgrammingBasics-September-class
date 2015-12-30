using System;
using System.Globalization;

class TheBetterMusicProducer
{
    static void Main()
    {
        int numberOfAlbumsEurope = int.Parse(Console.ReadLine());
        decimal priceOfAlbumEur = decimal.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        int numberOfAlbumsNorthAmerica = int.Parse(Console.ReadLine());
        decimal priceOfAlbumUsd = decimal.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        int numberOfAlbumsSouthAmerica = int.Parse(Console.ReadLine());
        decimal priceOfAlbumPesos = decimal.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        int numberOfConcerts = int.Parse(Console.ReadLine());
        decimal profitFromConcert = decimal.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        decimal firstProducerCommission = 0.35M;
        decimal secondProducerCommission = 0.15M;
        decimal taxes = 0.20M;

        decimal profitAlbumsEurope = (priceOfAlbumEur * numberOfAlbumsEurope) * 1.94M;
        decimal profitAlbumsNorthAmerica = (priceOfAlbumUsd * numberOfAlbumsNorthAmerica) * 1.72M;
        decimal profitAlbumsSouthAmerica = (priceOfAlbumPesos * numberOfAlbumsSouthAmerica) / 332.74M;


        decimal percentageCommission = (profitAlbumsEurope + profitAlbumsNorthAmerica + profitAlbumsSouthAmerica) * firstProducerCommission;
        decimal profitAllAlbums = (profitAlbumsEurope + profitAlbumsNorthAmerica + profitAlbumsSouthAmerica) - percentageCommission;
        decimal percentageTaxes = (profitAllAlbums) * taxes;
        decimal totalAlbumProfit = (profitAllAlbums) - percentageTaxes;
        decimal concertProfit = (numberOfConcerts * profitFromConcert) * 1.94M;

        if (concertProfit > 100000)
        {
            decimal percentageCommissionTwo = concertProfit * secondProducerCommission;
            concertProfit = concertProfit - percentageCommissionTwo;

        }
        if (totalAlbumProfit > concertProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalAlbumProfit);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertProfit);

        }
    }
}


