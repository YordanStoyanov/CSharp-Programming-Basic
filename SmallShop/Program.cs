using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();    
            string city = Console.ReadLine();
            double numberOfProducts = double.Parse(Console.ReadLine());
            decimal coffee = 0m;
            decimal water = 0m;
            decimal beer = 0m;
            decimal sweets = 0m;
            decimal peanuts = 0m;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    coffee = 0.50m;
                }
                else if (product == "water")
                {
                    water = 0.80m;
                }
                else if (product == "beer")
                {
                    beer = 1.20m;
                }
                else if (product == "sweets")
                {
                    sweets = 1.45m;
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.60m;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    coffee = 0.40m;
                }
                else if (product == "water")
                {
                    water = 0.70m;
                }
                else if (product == "beer")
                {
                    beer = 1.15m;
                }
                else if (product == "sweets")
                {
                    sweets = 1.30m;
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.50m;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    coffee = 0.45m;
                }
                else if (product == "water")
                {
                    water = 0.70m;
                }
                else if (product == "beer")
                {
                    beer = 1.10m;
                }
                else if (product == "sweets")
                {
                    sweets = 1.35m;
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.55m;
                }
            }
            decimal result = (decimal)numberOfProducts * (coffee + water + beer + sweets + peanuts);
            Console.WriteLine("{0}", result);
        }
    }
}
