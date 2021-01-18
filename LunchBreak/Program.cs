using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBreak
{
    public class Program
    {
        public static void Main()
        {
            string serialsName = Console.ReadLine();
            int durationEpisode = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());
            float durationForLanch = (float)durationBreak * (1f / 8f);
            float durationRest = (float)durationBreak * (1f / 4f);
            float durationChange = (float)durationBreak - durationForLanch - durationRest;

            if (durationChange >= durationEpisode)
            {
                Console.WriteLine("You have enough time to watch {0} and left with {1} minutes free time.", serialsName, Math.Ceiling(durationChange - (float)durationEpisode));
            }
            else
            {
                Console.WriteLine("You don't have enough time to watch {0}, you need {1} more minutes.", serialsName, Math.Ceiling((float)durationEpisode - durationChange));
            }
        }
    }
}
