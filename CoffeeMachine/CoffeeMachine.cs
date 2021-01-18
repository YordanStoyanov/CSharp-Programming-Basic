using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        public static void Main()
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());
            decimal withOutSugar = 0;            //цени за брой
            decimal withNormalSugar = 0;         //цени за брой
            decimal withExtraSugar = 0;          //цени за брой
            decimal result = 0;
            switch (drink)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        withOutSugar = 0.9m - 0.9m * (35m / 100m);
                    }
                    else if (sugar == "Normal")
                    {
                        withNormalSugar = 1m;
                    }
                    else if (sugar == "Extra")
                    {
                        withExtraSugar = 1.2m;
                    }

                    if (numberOfDrinks >= 5)
                    {
                        withExtraSugar = withExtraSugar - withExtraSugar * (25m / 100m);
                        withNormalSugar = withNormalSugar - withNormalSugar * (25m / 100m);
                        withOutSugar = withOutSugar - withOutSugar * (25m / 100m);
                        result = (withOutSugar + withNormalSugar + withExtraSugar) * (decimal)numberOfDrinks;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        withOutSugar = 1m - 1m * (35m / 100m);
                    }
                    else if (sugar == "Normal")
                    {
                        withNormalSugar = 1.2m;
                    }
                    else if (sugar == "Extra")
                    {
                        withExtraSugar = 1.6m;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        withOutSugar = 0.5m - 0.5m * (35m / 100m);
                    }
                    else if (sugar == "Normal")
                    {
                        withNormalSugar = 0.6m;
                    }
                    else if (sugar == "Extra")
                    {
                        withExtraSugar = 0.7m;
                    }
                    break;
            }
            result = (withOutSugar + withNormalSugar + withExtraSugar) * (decimal)numberOfDrinks;
            if (result > 15m)
            {
                Console.WriteLine("You bought {0} cups of {1} for {2:f2} lv.", numberOfDrinks, drink, result - result * (20m / 100m));
            }
            else if (result <= 15m)
            {
                Console.WriteLine("You bought {0} cups of {1} for {2:f2} lv.", numberOfDrinks, drink, result);
            }
        }
    }
}
