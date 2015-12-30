using System;

class BankAccount
{
    static void Main()
    {
        string fname = "John";
        string surname = "Edward";
        string lastname = "Smith";
        decimal balance = 250.368M;
        string iban = "BG80BNBG96611020345678";
        long creditcard1 = 4532477245089700;
        long creditcard2 = 4485825436161455;
        long creditcard3 = 5218781918663610;

        Console.WriteLine("First name: {0}", fname);
        Console.WriteLine("Middle name: {0}", surname);
        Console.WriteLine("Lastname: {0}", lastname);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards: {0}\n{1}\n{2}", creditcard1, creditcard2, creditcard3);
    }
}

