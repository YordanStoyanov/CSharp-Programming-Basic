using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfDays = int.Parse(Console.ReadLine());

            decimal studio = 0m;
            decimal apartment = 0m;

            if (month == "May" || month == "October")
            {
                if (numberOfDays <= 7)
                {
                    studio = 50m;
                    apartment = 65m;
                }
                else if (numberOfDays > 7 && numberOfDays <= 14)
                {
                    studio = 50m - (50m * 5m) / 100m;
                    apartment = 65m;
                }
                else if (numberOfDays > 14)
                {
                    studio = 50m - (50m * 30m) / 100m;
                    apartment = 65m - (65m * 10m) / 100m;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numberOfDays <= 14)
                {
                    studio = 75.2m;
                    apartment = 68.7m;
                }
                else if (numberOfDays > 14)
                {
                    studio = 75.2m - (75.2m * 20m) / 100m;
                    apartment = 68.7m - (68.7m * 10m) / 100m;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (numberOfDays <= 14)
                {
                    studio = 76m;
                    apartment = 77m;
                }
                else if (numberOfDays > 14)
                {
                    apartment = 77m - (77m * 10m) / 100m;
                    studio = 76m;
                }
            }
            decimal totalPriceForApartment = (decimal)numberOfDays * apartment;
            decimal totalPriceForStudio = (decimal)numberOfDays * studio;
            Console.WriteLine("Apartment: {0:f2} lv.", totalPriceForApartment);
            Console.WriteLine("Studio: {0:f2} lv.", totalPriceForStudio);
        }
    }
}
