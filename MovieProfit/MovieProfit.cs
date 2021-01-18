using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProfit
{
    class MovieProfit
    {
        static void Main()
        {
            string MoviesName = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfTickets = int.Parse(Console.ReadLine());
            decimal ticketPrice = decimal.Parse(Console.ReadLine());
            int percentForStudio = int.Parse(Console.ReadLine());
            decimal totalPriceForDay = (decimal)numberOfTickets * ticketPrice;
            decimal totalPriceForPeriodIfTime = totalPriceForDay * (decimal)numberOfDays;
            decimal percentFromTotalPrice = totalPriceForPeriodIfTime - totalPriceForPeriodIfTime * ((decimal)percentForStudio / 100m);
            Console.WriteLine("The profit from the movie {0} is {1:f2} lv.", MoviesName, percentFromTotalPrice);
        }
    }
}
