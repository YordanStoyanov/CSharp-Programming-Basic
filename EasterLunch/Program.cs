using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal easterBread = 3.2m;
            decimal twentyEggs = 4.35m;
            int numberOfTwentyEggs = 12;
            decimal cookiesPerKg = 5.40m;
            decimal eggsPaint = 0.15m;//perEgg

            int numberOfBreads = int.Parse(Console.ReadLine());
            int numberOfEggshells = int.Parse(Console.ReadLine());
            int kilogramOfCookies = int.Parse(Console.ReadLine());

            decimal totalCost = easterBread * (decimal)numberOfBreads + twentyEggs * (decimal)numberOfEggshells + cookiesPerKg * (decimal)kilogramOfCookies + (decimal)numberOfEggshells * eggsPaint * (decimal)numberOfTwentyEggs;
            Console.WriteLine("{0:f2}", totalCost);
        }
    }
}
