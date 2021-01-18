using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballEquipment
{
    public class BasketballEquipment
    {
        public static void Main()
        {
            decimal sumPerYear = decimal.Parse(Console.ReadLine());
            decimal baskShoes = sumPerYear - sumPerYear * (decimal)0.4;
            decimal baskClotes = baskShoes - baskShoes * (decimal)0.2;
            decimal baskBoll = baskClotes * (decimal)0.25;
            decimal baskAcces = baskBoll * (decimal)0.2;
            decimal totalSum = sumPerYear + baskShoes + baskClotes + baskBoll + baskAcces;
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
