using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Football
{
    private static readonly SortedDictionary<string, int> Teams = new SortedDictionary<string, int>()
        {
            {"Chelsea", 0},
            {"Manchester City", 0},
            {"Manchester United", 0},
            {"Everton", 0},
            {"Arsenal", 0},
            {"Liverpool", 0},
            {"Southampton", 0},
            {"Tottenham", 0}
        };

    static void Main()
    {
        decimal payment = decimal.Parse(Console.ReadLine());
        int count = 0;
        Regex lineSplitter = new Regex(@"\s+");

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "End of the league.")
            {
                break;
            }

            count++;
            string[] args = lineSplitter.Split(line).Where(s => s != string.Empty).ToArray();

            string team1 = args[0];
            Regex r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
            team1 = r.Replace(team1, " ");

            string team2 = args[2];
            team2 = r.Replace(team2, " ");
            string outcome = args[1];

            if (outcome == "2")
            {
                Teams[team2] += 3;
            }
            else if (outcome == "1")
            {
                Teams[team1] += 3;
            }
            else
            {
                Teams[team1]++;
                Teams[team2]++;
            }
            //Console.WriteLine(string.Join(", ", args));
        }

        decimal totalPayment = count * payment * 1.94m;
        Console.WriteLine("{0:f2}lv.", totalPayment);

        foreach (KeyValuePair<string, int> t in Teams)
        {
            string teamInfo = string.Format("{0} - {1} points.", t.Key, t.Value);
            Console.WriteLine(teamInfo);
        }
    }
}