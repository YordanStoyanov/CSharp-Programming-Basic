using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOffisherman = int.Parse(Console.ReadLine());
            decimal shipRentSpring = 0m;
            decimal shipRentSummerAutumn = 0m;
            decimal shipRentWinter = 0m;
            decimal result = 0m;

            if (numberOffisherman > 0 && numberOffisherman <=6)
            {
                if (season == "Spring")
                {
                    shipRentSpring = 3000m - (3000m * 10m) / 100m;
                }
                else if (season == "Summer")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 10m) / 100m;
                }
                else if (season == "Autumn")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 10m) / 100m;
                }
                else if (season == "Winter")
                {
                    shipRentWinter = 2600m - (2600m * 10m) / 100m;
                }
            }
            else if (numberOffisherman >= 7 && numberOffisherman <= 11)
            {
                if (season == "Spring")
                {
                    shipRentSpring = 3000m - (3000m * 15m) / 100m;
                }
                else if (season == "Summer")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 15m) / 100m;
                }
                else if (season == "Autumn")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 15m) / 100m;
                }
                else if (season == "Winter")
                {
                    shipRentWinter = 2600m - (2600m * 15m) / 100m;
                }
            }
            else if (numberOffisherman >= 12)
            {
                if (season == "Spring")
                {
                    shipRentSpring = 3000m - (3000m * 25m) / 100m;
                }
                else if (season == "Summer")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 25m) / 100m;
                }
                else if (season == "Autumn")
                {
                    shipRentSummerAutumn = 4200m - (4200m * 25m) / 100m;
                }
                else if (season == "Winter")
                {
                    shipRentWinter = 2600m - (2600m * 25m) / 100m;
                }
            }

            if (numberOffisherman % 2 == 0 && season != "Autumn")
            {
                if (season == "Spring")
                {
                    shipRentSpring = shipRentSpring - (shipRentSpring * 5m) / 100m;
                }
                else if (season == "Summer")
                {
                    shipRentSummerAutumn = shipRentSummerAutumn - (shipRentSummerAutumn * 5m) / 100m;
                }
                else if (season == "Winter")
                {
                    shipRentWinter = shipRentWinter - (shipRentWinter * 5m) / 100m;
                }
            }

            result = shipRentSpring + shipRentSummerAutumn + shipRentWinter;

            if (budget >= result)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - result);
            }
            else if (budget < result)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", result - budget);
            }
        }
    }
}
