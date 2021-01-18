using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton
{
    public class Skeleton
    {
        public static void Main()
        {
            decimal minets = decimal.Parse(Console.ReadLine());
            decimal seconds = decimal.Parse(Console.ReadLine());
            decimal uleyInMeters = decimal.Parse(Console.ReadLine());
            decimal secondsFor100Meters = decimal.Parse(Console.ReadLine());
            decimal meters = 120m; //
            decimal timeDecreaces = 2.5m;
            decimal controlInSeconds = minets * 60 + seconds;
            decimal howTimeDecreaces = uleyInMeters / meters;
            decimal totaldecreacesTimes = howTimeDecreaces * timeDecreaces;
            decimal theHumanTIme = (uleyInMeters / 100) * secondsFor100Meters - totaldecreacesTimes;
            if (controlInSeconds >= theHumanTIme)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine("His time is {0:f3}.", theHumanTIme);
            }
            else if (controlInSeconds < theHumanTIme)
            {
                
                Console.WriteLine("No, Marin failed! He was {0:f3} second slower.", theHumanTIme - controlInSeconds);
            }
        }
    }
}
