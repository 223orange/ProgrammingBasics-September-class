using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("1{0}101{0}1001{0}", Environment.NewLine);

        //int a = 1;
        //int b = 5;
        //int c = 9;
        //Console.WriteLine("{1}{0}{2}{0}{3}{0}", 
        //    Environment.NewLine, 
        //    Convert.ToString(a, 2).PadLeft(8),
        //    Convert.ToString(b, 2).PadLeft(8),
        //    Convert.ToString(c, 2).PadLeft(8));

        for (int i = 1; i < 10; i += 4)
        {
            Console.WriteLine(Convert.ToString(i, 2).PadLeft(8));
        }
    }
}