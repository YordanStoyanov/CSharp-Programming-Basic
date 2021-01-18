using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesCalculator
{
    public class SeriesCalculator
    {
        public static void Main()
        {
            string seriesName = Console.ReadLine();
            int numberOfSeasons = int.Parse(Console.ReadLine());
            int numberOfEpisodes = int.Parse(Console.ReadLine());
            double durationOfEpisodeWithOutAd = double.Parse(Console.ReadLine());
            double durationOfAdInAEpisode = (durationOfEpisodeWithOutAd * 20) / 100;
            double durationOfEpisodeWithAd = durationOfEpisodeWithOutAd + durationOfAdInAEpisode;
            double extraDurationAtFinalEpisodeInASeason = 10;
            double totalextraDurationAtFinalEpisodeInASeason = (double)numberOfSeasons * extraDurationAtFinalEpisodeInASeason;
            double result = durationOfEpisodeWithAd * (double)numberOfSeasons * (double)numberOfEpisodes + totalextraDurationAtFinalEpisodeInASeason;
            Console.WriteLine("Total time needed to watch the {0} series is {1} minutes.", seriesName, result);
        }
    }
}