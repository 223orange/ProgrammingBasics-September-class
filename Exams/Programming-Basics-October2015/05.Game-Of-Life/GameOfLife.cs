using System;

class GameOfLife
{

    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int coordinateX = 0;
        int coordinateY = 0;
        int[,] initialMatrix = new int[10, 10];
        int [,] coordinateMatrix = new int[n, 2];
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                coordinateMatrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                initialMatrix[row, col] = 0;
            }
        }

        for (int i = 0; i < coordinateMatrix.GetLength(0); i++)
        {
           
            for (int j = 0; j < coordinateMatrix.GetLength(1); j++)
            {
                coordinateY = coordinateMatrix[0,j];
                coordinateX = coordinateMatrix[i, 0];
                initialMatrix[coordinateX, coordinateY] = initialMatrix[coordinateX, coordinateY] | 1;
            }
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(initialMatrix[row,col]);
            }
            Console.WriteLine();
        }


    }
}


