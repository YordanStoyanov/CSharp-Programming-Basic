using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal thePriceOfFlourPerKilogram = decimal.Parse(Console.ReadLine());
            double numberOfKgOfFlour = double.Parse(Console.ReadLine());
            double numberOfKgOfSugar = double.Parse(Console.ReadLine());
            int numberOfAShellOfEggs = int.Parse(Console.ReadLine());
            int numberOfPackOfYeast = int.Parse(Console.ReadLine());

            decimal thePricePerKilogramOfSugar = thePriceOfFlourPerKilogram - (thePriceOfFlourPerKilogram * 25m) / 100m;
            decimal thePriceOfAShellOfEggs = thePriceOfFlourPerKilogram + (thePriceOfFlourPerKilogram * 10m) / 100m;
            decimal thePriceOfOnePackOfYeast = thePricePerKilogramOfSugar - (thePricePerKilogramOfSugar * 80m) / 100m;
            decimal result = thePricePerKilogramOfSugar + thePriceOfAShellOfEggs + thePriceOfOnePackOfYeast;
        }
    }
}
