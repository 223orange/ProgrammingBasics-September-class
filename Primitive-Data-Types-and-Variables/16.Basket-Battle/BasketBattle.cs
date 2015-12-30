using System;
using System.Linq;

class BasketBattle
{
    

    static void Main()
    {
        string[] F = { "Simeon", "Nakov" };

        int numrounds;
        int points;
        int player1 = 0;
        int player2 = 0;
        int counter = 0;
        int roundSimeon = 0;
        int roundNakov = 0;
        int max1 = 0;
        int max2 = 0;

        string name = Console.ReadLine(); // Get string from user
        if (name == F[0] || name == F[1])
        {

            numrounds = int.Parse(Console.ReadLine());

            for (counter = 0; counter <= numrounds*2 ; counter++)
            {
                points = int.Parse(Console.ReadLine());


                string I = Console.ReadLine();

                if (counter % 2 == 0 && I == "success")
                {
                    player1 = +points;
                    int[] simeonPoints = new int[numrounds];
                    for (int i = 0; i < numrounds; i++)
                    {
                        simeonPoints[i] = points;

                    }
                    max1 = simeonPoints.Max();
                    roundSimeon = Array.FindIndex(simeonPoints, item => item == max1);
                    if (player1 >= 500)

                    {
                        Console.WriteLine(F[0]);
                        Console.WriteLine(roundSimeon);
                        Console.WriteLine(max1);
                        break;

                    }
                    else
                    {
                        player2 = +points;
                        int[] nakovPoints = new int[numrounds];
                        for (int j = 0; j < numrounds; j++)
                        {
                            nakovPoints[j] = points;
                        }
                        max2 = nakovPoints.Max();
                        roundNakov = Array.FindIndex(nakovPoints, item => item == max2);
                        if (player2 >= 500)
                        {
                            Console.WriteLine(F[1]);
                            Console.WriteLine(roundNakov);
                            Console.WriteLine(max2);
                            break;
                        }

                    }

                }
            }
        }   

        else
        {

            Console.WriteLine("NO");
        }
    }
}
