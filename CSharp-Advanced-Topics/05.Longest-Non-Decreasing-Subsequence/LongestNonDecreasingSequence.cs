using System;

public class Program
{
    public static void Main()
    {
        string [] lineNumber = Console.ReadLine().Split();
        int[] nums = new int[lineNumber.Length];
        for (int i = 0; i < lineNumber.Length; i++)
        {
            nums[i] = int.Parse(lineNumber[i]);
        }

        string[] paths = new string[nums.Length];
        int[] sizes = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            sizes[i] = 1;
            paths[i] = nums[i] + " ";
        }
        int maxLength = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if(nums[i]>nums[j] && sizes[i]<sizes[j]+1)
                {
                    sizes[i] = sizes[j] + 1;
                    paths[i] = paths[j] + nums[i] + " ";

                    if (maxLength < sizes[i])
                        maxLength = sizes[i];
                }
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if(sizes[i] == maxLength)
                Console.Write(paths[i] + " ");
        }


    }
}