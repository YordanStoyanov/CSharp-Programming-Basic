using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public class FoodDelivery
    {
        public static void Main()
        {
            int NumberOfChickenMenus = int.Parse(Console.ReadLine());
            int NumberOfFishMenus = int.Parse(Console.ReadLine());
            int NumberOfVegetarianMenus = int.Parse(Console.ReadLine());
            decimal chickenMenus = 10.35m;
            decimal fishMenus = 12.40m;
            decimal vegetarianMenus = 8.15m;
            decimal total = (decimal)NumberOfChickenMenus * chickenMenus + (decimal)NumberOfFishMenus * fishMenus + (decimal)NumberOfVegetarianMenus * vegetarianMenus;
            decimal disert = (total * 20m) / 100m;
            decimal delivery = 2.5m;
            decimal result = total + disert + delivery;
            Console.WriteLine("Total: {0:f2}", result);
        }
    }
}
