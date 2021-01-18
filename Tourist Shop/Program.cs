using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            decimal totalPrice = 0;
            decimal result = 0;
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "Stop")
                {
                    Console.WriteLine("You bought {0} products for {1:f2} leva.", p2, result);
                    break;
                }
                decimal productPrice = decimal.Parse(Console.ReadLine());
                p1++;
                if (p1 % 3 == 0)
                {
                    productPrice /= 2;
                }
                totalPrice = budget - productPrice;
                result += productPrice;
                p2++;
                if (result > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine("You need {0:f2} leva!", result - budget);
                    break;
                }

            }
        }
    }
}
