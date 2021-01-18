using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisEquipment
{
    public class TennisEquipment
    {
        public static void Main()
        {
            decimal tennisRacketPrice = decimal.Parse(Console.ReadLine());
            int tennisRacketsNumber = int.Parse(Console.ReadLine());
            int tennisShoesNubmer = int.Parse(Console.ReadLine());
            decimal totalTennisRacketsPrice = tennisRacketPrice * (decimal)tennisRacketsNumber;
            decimal tennisShoesPait = tennisRacketPrice / (decimal)6;
            decimal totalTennisShoesNumberPrice = tennisShoesNubmer * tennisShoesPait;
            decimal otherPriceEquipment = (totalTennisRacketsPrice + totalTennisShoesNumberPrice) * (decimal)0.2;
            decimal totalPrice = totalTennisRacketsPrice + totalTennisShoesNumberPrice + otherPriceEquipment;
            decimal djokovicsPrice = Math.Floor(totalPrice / (decimal)8);
            decimal sponsorsPrice = Math.Ceiling(totalPrice * ((decimal)7 / 8));
            Console.WriteLine("Price to be paid by Djokovic {0}", djokovicsPrice);
            Console.WriteLine("Price to be paid by sponsors {0}", sponsorsPrice);
        }
    }
}
