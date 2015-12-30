using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");

        Console.Write("Enter your birth date: ");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = (int)((now - birthDay).TotalDays / 365.242199);
        Console.WriteLine("Now: " + age);
        Console.WriteLine("After 10 years: " + (age + 10));
    }
}