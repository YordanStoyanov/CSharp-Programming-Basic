using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal depositSum = decimal.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double AnnualInterestRate = double.Parse(Console.ReadLine());

            decimal sum = depositSum + (decimal)depositPeriod * (((depositSum * (decimal)AnnualInterestRate / 100m) / 12m));
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
