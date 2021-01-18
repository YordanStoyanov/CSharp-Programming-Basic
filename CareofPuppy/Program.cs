using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareofPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGrams = food * 1000;
            string eated = null;
            int eatedFoodSum = 0;
            int eatedFood = 0;
            int change = 0;
            while (true)
            {
                eated = Console.ReadLine();

                if (eated == "Adopted")
                {
                    if (eatedFoodSum <= foodInGrams)
                    {
                        Console.WriteLine("Food is enough! Leftovers: {0} grams.", change);
                    }
                    else
                    {
                        Console.WriteLine("Food is not enough. You need {0} grams more.", eatedFoodSum - foodInGrams);
                    }
                    break;
                }
                eatedFood = int.Parse(eated);
                eatedFoodSum += eatedFood;
                change = foodInGrams - eatedFoodSum;
            }
        }
    }
}
