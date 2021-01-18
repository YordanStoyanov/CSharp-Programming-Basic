using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal usdToBg = 1.79549m;
            decimal toBg = usd * usdToBg;
            Console.WriteLine(toBg);

        }
    }
}
