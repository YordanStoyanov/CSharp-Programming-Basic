using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDay
{
    public class PoolDay
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            decimal entranceFeeOfPeople = decimal.Parse(Console.ReadLine());
            decimal priceOfADeckChair = decimal.Parse(Console.ReadLine());
            decimal priceForUmbrella = decimal.Parse(Console.ReadLine());

            decimal totalFee = (decimal)numberOfPeople * entranceFeeOfPeople;
            decimal totalDeckChair = Math.Ceiling((decimal)numberOfPeople * (decimal)(75/100m)) * priceOfADeckChair;
            decimal totalFeeForUmbprella = Math.Ceiling((decimal)numberOfPeople * (decimal)(50/100m)) * priceForUmbrella;
            decimal result = totalFee + totalDeckChair + totalFeeForUmbprella;
            Console.WriteLine("{0:f2} lv.", result);
        }
    }
}
