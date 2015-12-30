using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = (double)(2 * width) + (2 * height);
        double area = height * width;

        Console.WriteLine("The Perimeter is {0} !",perimeter);
        Console.WriteLine("The Area is {0} !", area);
    }
}

