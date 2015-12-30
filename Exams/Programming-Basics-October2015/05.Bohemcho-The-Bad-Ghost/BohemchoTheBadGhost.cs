using System;

class BohemchoTheBadGhost
{

    static void Main()
    {
        string initialstate = Console.ReadLine();
        long finalNum = 0;
        int lightsOn = 0;

        while (initialstate != "Stop, God damn it")
        {
            uint floorNum = uint.Parse(initialstate);
            string line = Console.ReadLine();
            string[] numberStrs = line.Split(' ');
            int[] appartmentNum = new int[numberStrs.Length];

            for (int i = 0; i < appartmentNum.Length; i++)
            {
                appartmentNum[i] = int.Parse(numberStrs[i]);
            }
            for (int i = 0; i < appartmentNum.Length; i++)
            {
                floorNum = floorNum ^ (1U << appartmentNum[i]);
            }
            for (int i = 0; i < 32; i++)
            {
                if (((floorNum >> i) & 1) == 1)
                {
                    lightsOn++;
                }
            }
            finalNum += floorNum;

            initialstate = Console.ReadLine();
        }
        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lightsOn, finalNum);
    }
}

