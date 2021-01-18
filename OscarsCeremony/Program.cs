using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double hollsRent = int.Parse(Console.ReadLine());
            double figurines = hollsRent - (hollsRent * 30) / 100;
            double catering = figurines - (figurines * 15) / 100;
            double soundSystem = (catering * 1) / 2;

            double result = hollsRent + figurines + catering + soundSystem;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
