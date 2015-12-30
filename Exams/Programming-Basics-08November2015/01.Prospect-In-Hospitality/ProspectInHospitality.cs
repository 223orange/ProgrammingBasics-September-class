using System;
using System.Globalization;


class ProspectInHospitality
{
    static void Main()
    {

        uint builders = uint.Parse(Console.ReadLine());
        uint receptionist = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technicians = uint.Parse(Console.ReadLine());
        uint amountOfOtherStaff = uint.Parse(Console.ReadLine());

        decimal salaryNiki = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal currencyRate = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal yourSalary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal budjet = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        decimal result;

        decimal builderSalary = builders * 1500.04m;
        decimal receptionistSalary = receptionist * 2102.10m;
        decimal chambermaidsSalary = chambermaids * 1465.46m;
        decimal techniciansSalary = technicians * 2053.33m;
        decimal otherstSalary = amountOfOtherStaff * 3010.98m;
        decimal salaryNikiLv = salaryNiki * currencyRate;


        decimal totalBudjetForSalaries = builderSalary + receptionistSalary + chambermaidsSalary + techniciansSalary +
                                        otherstSalary + salaryNikiLv + yourSalary;

        if(totalBudjetForSalaries <= budjet)
        {
            result = budjet - totalBudjetForSalaries;
            Console.WriteLine("The amount is: {0:F2} lv.", totalBudjetForSalaries);
            Console.WriteLine("YES \\ Left: {0:F2} lv.", result);
        }
        else
        {
            result = totalBudjetForSalaries - budjet;
            Console.WriteLine("The amount is: {0:F2} lv.", totalBudjetForSalaries);
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", result);
        }
    }
}

