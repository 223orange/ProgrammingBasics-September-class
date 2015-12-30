using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        DateTime now = DateTime.Now;
        
        Console.WriteLine(now);
        Console.ReadLine();
    }
}