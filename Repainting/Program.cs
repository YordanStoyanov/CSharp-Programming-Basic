using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repainting
{
    public class Program
    {
        public static void Main()
        {
            int amountOfNylon = int.Parse(Console.ReadLine());
            int amountOfPiant = int.Parse(Console.ReadLine());
            int amountOfThinner = int.Parse(Console.ReadLine());
            int humansHour = int.Parse(Console.ReadLine());

            decimal totalAmountOfNylon = ((decimal)amountOfNylon + 2m) * (3/2m);
            decimal totalAmountOfPaint = (((decimal)amountOfPiant + ((decimal)amountOfPiant * (1/10m)))) * (29/2m);
            decimal totalAmountOfThinner = (decimal)amountOfThinner * 5m;
            decimal totalPrice = totalAmountOfNylon + totalAmountOfPaint + totalAmountOfThinner + (40/100m);
            decimal priceForEightHours = (decimal)totalPrice * (30/100m) * humansHour;
            decimal result = totalPrice + priceForEightHours;

            Console.WriteLine("Total expenses: {0:f2} lv.", result);
        }
    }
}
