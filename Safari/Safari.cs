using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    public class Safari
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            string WeekendDay = Console.ReadLine();
            decimal fuelPrice = 2.1m;
            decimal guide = 100m;
            decimal totalFuelPries = (decimal)fuelConsumption * fuelPrice;
            decimal priceFuelWithGuide = totalFuelPries + guide;
            if (WeekendDay == "Saturday")
            {
                priceFuelWithGuide = priceFuelWithGuide - (priceFuelWithGuide * 10m) / 100m;
            }
            else if (WeekendDay == "Sunday")
            {
                priceFuelWithGuide = priceFuelWithGuide - (priceFuelWithGuide * 20m) / 100m;
            }
            if (budget >= priceFuelWithGuide)
            {
                Console.WriteLine("Safari time! Money left: {0:f2} lv. ", budget - priceFuelWithGuide);
            }
            else if (budget < priceFuelWithGuide)
            {
                Console.WriteLine("Not enough money! Money needed: {0:f2} lv.", priceFuelWithGuide - budget);
            }
        }
    }
}
