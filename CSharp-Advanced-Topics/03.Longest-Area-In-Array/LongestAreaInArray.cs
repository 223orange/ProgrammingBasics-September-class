using System;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
       int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int maxCounter = 1;
        int index = 0;
        string[] textElements = new string[n];
        string[] resultArray = new string[maxCounter];
      
        for (int i = 0; i < n; i++)
        {
            textElements[i] = Console.ReadLine();
        }
        for(int i = 1; i < textElements.Length; i++)
        {
            if(textElements[i].SequenceEqual(textElements[i-1]))
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if(counter > maxCounter)
            {
                maxCounter = counter;
                index = i - maxCounter + 1;
            }
        }
        Console.WriteLine(counter);
        for (int i = index; i < maxCounter + index; i++)
        {
            Console.WriteLine(textElements[i]);
        }
    }
}

