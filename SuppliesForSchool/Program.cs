using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesForSchool
{
    public class Program
    {
        public static void Main()
        {
            int numberOfPenPackages = int.Parse(Console.ReadLine());
            int numberOfMarkersPackages = int.Parse(Console.ReadLine());
            double literOfDetergentForCleaning = double.Parse(Console.ReadLine());
            int percentReduction = int.Parse(Console.ReadLine());

            decimal PenPackages = 5.80m;
            decimal MarkersPackages = 7.20m;
            decimal literOfDetergent = 1.20m;
            decimal totalCost = (decimal)numberOfPenPackages * PenPackages + (decimal)numberOfMarkersPackages * MarkersPackages + (decimal)literOfDetergentForCleaning * literOfDetergent;
            decimal result = totalCost - ((totalCost * (decimal)percentReduction) / 100m);
            Console.WriteLine("{0:f3}", result);
        }
    }
}
