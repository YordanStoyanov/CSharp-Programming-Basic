using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numberOfFlower = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double total = 0;
            double result = 0;

            if (typeFlower == "Sunflower")
            {
                if (season == "Spring")
                {
                    total = 10;
                    result = (double)numberOfFlower * total;
                }
                else if (season == "Summer")
                {
                    total = 8;
                    result = (double)numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;
                }
                else if (season == "Autumn")
                {
                    total = 12;
                    result = numberOfFlower * total - ((double)numberOfFlower * total * (double)5) / (double)100;
                }
            } 
            else if (typeFlower == "Daisy")
            {
                if (season == "Spring")
                {
                    total = 12;
                    result = numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;

                }
                else if (season == "Summer")
                {
                    total = 8;
                    result = numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;
                }
                else if (season == "Autumn")
                {
                    total = 6;
                    result = numberOfFlower * total - ((double)numberOfFlower * total * (double)5) / (double)100;
                }
            }
            else if (typeFlower == "Lavender")
            {
                if (season == "Spring")
                {
                    total = 12;
                    result = numberOfFlower * total;
                }
                else if (season == "Summer")
                {
                    total = 8;
                    result = numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;
                }
                else if (season == "Autumn")
                {
                    total = 6;
                    result = numberOfFlower * total - ((double)numberOfFlower * total * (double)5) / (double)100;
                }
            }
            else if (typeFlower == "Mint")
            {
                if (season == "Spring")
                {
                    total = 10;
                    result = numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;
                }
                else if (season == "Summer")
                {
                    total = 12;
                    result = numberOfFlower * total + ((double)numberOfFlower * total * (double)10) / (double)100;
                }
                else if (season == "Autumn")
                {
                    total = 6;
                    result = numberOfFlower * total - ((double)numberOfFlower * total * (double)5) / (double)100;
                }
            }

            Console.WriteLine("Total honey harvested: {0:f2}", result);

        }
    }
}
