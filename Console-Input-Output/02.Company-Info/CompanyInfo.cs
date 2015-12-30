using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string address = Console.ReadLine();
        string phoneNum = (Console.ReadLine());
        string number = String.Format("{0:+### ### ## ## ##}", phoneNum);
        string faxNumber = Console.ReadLine(); 
        if (faxNumber.Length == 0)
        {
            faxNumber = "no fax";
        }
        string webSite = Console.ReadLine();
        string firstName= Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string phoneMan = Console.ReadLine();
        string numberMan = String.Format("{0:+### # ### ###}", phoneMan);

        Console.WriteLine("{1}{0}Adrress: {2}{0}Tel. {3}{0}Fax: {4}{0}Web site: {5}{0}Manager: {6} {7}(age:{0} {8}, tel. {9}", Environment.NewLine, companyName, address, 
                            number, faxNumber, webSite, firstName, lastName, age, numberMan);

    }
}

