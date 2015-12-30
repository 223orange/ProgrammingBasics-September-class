using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();
        DateTime expectedDate;
        bool checkFirstDate = DateTime.TryParseExact(firstDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out expectedDate);
        bool checkSecondDate = DateTime.TryParseExact(secondDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out expectedDate);
        if (checkFirstDate == true && checkSecondDate == true)
        {
            DateTime convFirstDate = DateTime.ParseExact(firstDate, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime convSecondDate = DateTime.ParseExact(secondDate, format, System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan span = convSecondDate.Subtract(convFirstDate);
            int result = (int)span.TotalDays;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}

