using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numberOfStatist = double.Parse(Console.ReadLine());
            double priceOfClothes = double.Parse(Console.ReadLine());

            double decorSum = (budget * 10) / 100;
            double clothingSum = 0;
            if (numberOfStatist >= 150)
            {
                clothingSum = numberOfStatist * priceOfClothes - (numberOfStatist * priceOfClothes * 10) / 100;
            }
            else if (numberOfStatist < 150)
            {
                clothingSum = numberOfStatist * priceOfClothes;
            }
            double total = decorSum + clothingSum;

            if (budget - total > 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.", budget - total);
            }
            else if (total - budget > 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more.", total - budget);
            }
        }
    }
}
