using System;
using System.Globalization;

class SudokuResults
{
    static void Main()
    {
        string input = "";
        int result = 0;
        int counter = 0;
        input = Console.ReadLine();

        while (input != "Quit")
        {
            counter++;
            int[] numArray = new int[input.Length];
            string[] numstrArray = input.Split(':');
            for (int i = 0; i < numstrArray.Length; i++)
            {
                numArray[i] = int.Parse(numstrArray[i]);
                
            }
            result = +result + (numArray[0] * 60) + numArray[1];

            input = Console.ReadLine();
            
        }


        double average = Math.Ceiling((double)result / counter);

        if(average <= 720)
        {
            Console.WriteLine("Gold Star{0}Games - {1} \\ Average seconds - {2}", Environment.NewLine, counter, average);
        }
        if(average > 720 && average < 1440)
        {
            Console.WriteLine("Silver Star{0}Games - {1} \\ Average seconds - {2}", Environment.NewLine, counter, average);
        }
        if(average >= 1440)
        {
            Console.WriteLine("Bronze Star{0}Games - {1} \\ Average seconds - {2}", Environment.NewLine, counter, average);
        }
    }

}


