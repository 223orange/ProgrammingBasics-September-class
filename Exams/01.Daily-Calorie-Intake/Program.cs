using System;
using System.Globalization;

class DailyCalorieIntake
{
    static void Main()
    {

        double weightPoinds = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double heightInches = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int age = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        if (gender == "m" || gender == "f")
        {
            int workouts = int.Parse(Console.ReadLine());
            if (workouts >= 0)
            {
                double weightKilos = weightPoinds / 2.2;
                double heightCentim = heightInches * 2.54;

                double bmrMen = 66.5 + (13.5 * weightKilos) + (5.003 * heightCentim) - (6.755 * age);
                double bmrWomen = 655 + (9.563 * weightKilos) + (1.850 * heightCentim) - (4.676 * age);

                if (gender == "m" || gender == "f")
                    if (gender == "m")
                    {
                        if (workouts == 0)
                        {
                            double dailyCalIntake = bmrMen * 1.2;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }

                        if (workouts >= 1 && workouts <= 3)
                        {
                            double dailyCalIntake = bmrMen * 1.375;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 4 && workouts <= 6)
                        {
                            double dailyCalIntake = bmrMen * 1.55;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 7 && workouts <= 9)
                        {
                            double dailyCalIntake = bmrMen * 1.725;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 9)
                        {
                            double dailyCalIntake = bmrMen * 1.9;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                    }
                    else
                    {
                        if (workouts < 1)
                        {
                            double dailyCalIntake = bmrWomen * 1.2;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 1 && workouts <= 3)
                        {
                            double dailyCalIntake = bmrWomen * 1.375;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 4 && workouts <= 6)
                        {
                            double dailyCalIntake = bmrWomen * 1.55;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 7 && workouts <= 9)
                        {
                            double dailyCalIntake = bmrWomen * 1.725;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                        if (workouts >= 9)
                        {
                            double dailyCalIntake = bmrWomen * 1.9;
                            double dailyCalIntakeRound = Math.Floor(dailyCalIntake);
                            Console.WriteLine(dailyCalIntakeRound);
                        }
                    }
            }
            else
            {
                Console.WriteLine("Enter a valid number > = 0");
            }
        }

        else
        {
            Console.WriteLine("Please enter m or f ");
        }
    }
}



