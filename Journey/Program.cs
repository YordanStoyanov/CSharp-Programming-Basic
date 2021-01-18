using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            decimal summer = 0m;
            decimal winter = 0m;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    summer = budget * 30m / 100m;
                }
                else if (season == "winter")
                {
                    winter = budget * 70m / 100m;
                }

                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", summer);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", winter);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    summer = budget * 40m / 100m;
                }
                else if (season == "winter")
                {
                    winter = budget * 80m / 100m;
                }
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", summer);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", winter);
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer")
                {
                    summer = budget * 90m / 100m;
                }
                else if (season == "winter")
                {
                    winter = budget * 90m / 100m;
                }

                Console.WriteLine("Somewhere in Europe");
                if (season == "summer")
                {
                    Console.WriteLine("Hotel - {0:f2}", summer);
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", winter);
                }
            }
        }
    }
}
