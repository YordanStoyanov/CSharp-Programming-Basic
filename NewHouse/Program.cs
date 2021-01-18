using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //&quot;Roses&quot;, &quot;Dahlias&quot;, &quot;Tulips&quot;, &quot;Narcissus&quot;, &quot;Gladiolus&quot;
            string flowersType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal Roses = 5m;
            decimal Dahlias = 3.80m;
            decimal Tulips = 2.80m;
            decimal Narcissus = 3m;
            decimal Gladiolus = 2.50m;
            decimal result = 0m;
            if (flowersType == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    result = Roses * (decimal)numberOfFlowers - ((Roses * (decimal)numberOfFlowers * 10m) / 100m);
                }
                else
                {
                    result = Roses * (decimal)numberOfFlowers;
                }
                
            }
            else if (flowersType == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    result = Dahlias * (decimal)numberOfFlowers - ((Dahlias * (decimal)numberOfFlowers * 15m) / 100m);
                }
                else
                {
                    result = Dahlias * (decimal)numberOfFlowers;
                }
            }
            else if (flowersType == "Tulips")
            {
                if (numberOfFlowers > 80)
                {

                    result = Tulips * (decimal)numberOfFlowers - ((Tulips * (decimal)numberOfFlowers * 15m) / 100m);
                }
                else
                {
                    result = Tulips * (decimal)numberOfFlowers;
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    result = Narcissus * (decimal)numberOfFlowers + ((Narcissus * (decimal)numberOfFlowers * 15m) / 100m);
                }
                else
                {
                    result = Narcissus * (decimal)numberOfFlowers;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    result = Gladiolus * (decimal)numberOfFlowers + ((Gladiolus * (decimal)numberOfFlowers * 20m) / 100m);
                }
                else
                {
                    result = Gladiolus * (decimal)numberOfFlowers;
                }
            }


            if (budget >= result)
	        {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", numberOfFlowers, flowersType, budget - result);
	        }
            else if (budget < result)
	        {
                Console.WriteLine("Not enough money, you need {0:f2} leva more.", result - budget);
	        }
        }
    }
}
