using System;
using System.Globalization;

class TorrentPirate
{
    static void Main()

    {
        int data = int.Parse(Console.ReadLine());
        int price = int.Parse(Console.ReadLine());
        int wspending = int.Parse(Console.ReadLine());
       

        double dtime = (double)data / 2 / 60 / 60;
        double pdownload = dtime * wspending;
        double numbermovies = (double)data / 1500;
        double cinemaprice = (double)numbermovies * price;

        if (pdownload > cinemaprice)
        {
            Console.WriteLine("cinema -> {0}lv", String.Format(CultureInfo.InvariantCulture,"{0:0.00}", cinemaprice));
        }
        else
        {
            Console.WriteLine("mall -> {0}lv", String.Format(CultureInfo.InvariantCulture, "{0:0.00}", pdownload)); 
        }
    }
}
    

