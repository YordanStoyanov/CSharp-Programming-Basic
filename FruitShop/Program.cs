using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string weeksDay = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            decimal banana = 0m;
            decimal apple = 0m;
            decimal orange = 0m;
            decimal grapefruit = 0m;
            decimal kiwi = 0m;
            decimal pineapple = 0m;
            decimal grapes = 0m;

            if (weeksDay == "Monday" || weeksDay == "Tuesday" || weeksDay == "Wednesday" || weeksDay == "Thursday" || weeksDay == "Friday")
            {
                if (product == "banana")
                {
                    banana = 2.50m;
                }
                else if (product == "apple")
                {
                    
                apple = 1.20m;
                }
                else if (product == "orange")
                {
                    
                orange = 0.85m;
                }
                else if (product == "grapefruit")
                {
                    
                grapefruit = 1.45m;
                }
                else if (product == "kiwi")
                {
                    
                kiwi = 2.70m;
                }
                else if (product == "pineapple")
                {
                    
                pineapple = 5.50m;
                }
                else if (product == "grapes")
                {
                    
                grapes = 3.85m;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (weeksDay == "Saturday" || weeksDay == "Sunday")
            {
                if (product == "banana")
                {
                banana = 2.70m;
                    
                }
                else if (product == "apple")
                {
                    
                apple = 1.25m;
                }
                else if (product == "orange")
                {

                    orange = 0.90m;
                }
                else if (product == "grapefruit")
                {
                    
                grapefruit = 1.60m;
                }
                else if (product == "kiwi")
                {
                    
                kiwi = 3.00m;
                }
                else if (product == "pineapple")
                {
                    
                pineapple = 5.60m;
                }
                else if (product == "grapes")
                {
                    
                grapes = 4.20m;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            decimal resulit = (banana + apple + orange + grapefruit + kiwi + pineapple + grapes) * (decimal)value;
            if (resulit > 0)
            {
                
            Console.WriteLine("{0:f2}", resulit);
            }

        }
    }
}
