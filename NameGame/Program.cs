using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeamName = Console.ReadLine();
            int numberOfMatchesPlayedInSeason = int.Parse(Console.ReadLine());
            int wons = 0;
            int equally = 0;
            int losses = 0;
            double winRate = 0;
            if (numberOfMatchesPlayedInSeason > 0)
            {
                for (int i = 0; i < numberOfMatchesPlayedInSeason; i++)
                {
                    string games = Console.ReadLine();
                    if (games == "W")
                    {
                        wons++;
                    }
                    else if (games == "D")
                    {
                        equally++;
                    }
                    else if (games == "L")
                    {
                        losses++;
                    }
                }
                winRate = (double)wons * 100 / ((double)wons + (double)equally + (double)losses);
                Console.WriteLine("{0} has won {1} points during this season.", footballTeamName, ((wons * 3) + (equally * 1) + (losses * 0)));
                Console.WriteLine("Total stats:");
                Console.WriteLine("## W: {0}", wons);
                Console.WriteLine("## D: {0}", equally);
                Console.WriteLine("## L: {0}", losses);
                Console.WriteLine("Win rate: {0:f2}%", winRate);
            }
            else if (numberOfMatchesPlayedInSeason <= 0)
            {
                Console.WriteLine("{0} hasn't played any games during this season.", footballTeamName);
            }
        }
    }
}
