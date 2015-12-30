using System;
using System.Text.RegularExpressions;

class PerfectGirlfriend
{
    static void Main()
    {
        string input = Console.ReadLine();
        int day = 0;
        int phoneNumTotal = 0;
        int nameTotal = 0;
        int totalSum = 0;
        int counter = 0;
        int valBra = 0;
      

        while (input != "Enough dates!")
        {
            string[] line = input.Split('\\');

            string dayOfTheWeek = line[0];
            string phoneNum = line[1];
            char[] braSize = line[2].ToCharArray();
            char[] nameArray = line[3].ToCharArray();

            switch (dayOfTheWeek)
            {
                case "Monday":
                    {
                        day = 1;
                        break;
                    }
                case "Tuesday":
                    {
                        day = 2;
                        break;
                    }
                case "Wednasday":
                    {
                        day = 3;
                        break;
                    }
                case "Thursday":
                    {
                        day = 4;
                        break;
                    }
                case "Friday":
                    {
                        day = 5;
                        break;
                    }
                case "Saturday":
                    {
                        day = 6;
                        break;
                    }
                case "Sunday":
                    {
                        day = 7;
                        break;
                    }
            }
            for (int i = 0; i < phoneNum.Length; i++)
            {
                string phoneDigit = phoneNum[i].ToString();
                phoneNumTotal = +int.Parse(phoneDigit);
            }

            for (int i = 0; i < nameArray.Length; i++)
            {
                nameTotal = +(int)nameArray[i];
            }

            char size = braSize[braSize.Length - 1];
            valBra = +(int)size;
            string[] number = new string [braSize.Length - 1];
            for (int i = braSize.Length-2; i>=0; i--)
            {
                number[i]= Convert.ToString(braSize[i]);
                
            
            }


             totalSum = day + phoneNumTotal + nameTotal + valBra;
            string name = nameArray.ToString();

            if(totalSum >=6000)
            {
                Console.WriteLine("{0} is perfect for you", name );
            }
            else
            {
                Console.WriteLine("Keep searching, {0] is not for you", name);
            }
            
        }
        Console.WriteLine(counter);
    }
}

