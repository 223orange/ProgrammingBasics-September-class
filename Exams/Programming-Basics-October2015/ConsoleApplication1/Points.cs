using System;
using System.Text.RegularExpressions;

class Points
    {
     static void Main()
     {
        string input = Console.ReadLine();
        string path = Console.ReadLine();
        string[] numbers = Regex.Split(input, @"\D+");
        int[] numArray = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (!string.IsNullOrEmpty(numbers[i]))
            {
                numArray[i] = int.Parse(numbers[i]);
            }
        }
        int x = numArray[0];
        int y = numArray[1];
        int counter = 1;

        for (int i = 0; i < path.Length; i++)

        {

            if (path[i] == '~')
            {
                counter++;
            }

            if (counter % 2 == 0)
            {
                if (path[i] != '<')
                {
                    x--;
                }
                if (path[i] != '>')
                {
                    x++;
                }
                if (path[i] != '^')
                {
                    y--;
                }
                if (path[i] != 'v')
                {
                    y++;
                }
            }
            if (counter % 2 != 0)
            {
                if (path[i] != '<')
                {
                    x++;
                }
                if (path[i] != '>')
                {
                    x--;
                }
                if (path[i] != '^')
                {
                    y++;
                }
                if (path[i] != 'v')
                {
                    y--;
                }
            }
        }
        Console.WriteLine("({0}, {1})",x,y);
    }
}

