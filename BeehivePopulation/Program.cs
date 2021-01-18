using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int p1 = 0;
            double bees = 0;
            int total = 0;
            int deethBees = 0;
            double away = 0;
            int change = 0;
            double result = 0;
            bees = Math.Floor((double)initialPopulation / 10) * 2;
            total = initialPopulation + (int)bees;
            change = (total / 20) * 2;
            result = (double)total - (double)change;
            for (int i = 1; i <= years; i++)
            {
                bees = (result / 10) * 2;
                total = (int)result + (int)bees;

                if (i % 5 == 0)
                {
                    away = (Math.Floor(total / (double)50) * (double)5);
                    change = total - (int)away;
                }
                change = (total / 20) * 2;
                result = total - change;
            }
            Console.WriteLine("Beehive population: {0}", result);
            //Console.WriteLine(total);
            //Console.WriteLine("Beehive population: {0}", result);
        }
    }
}
