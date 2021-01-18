using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            string sum = null;
            double nextSum = 0;
            double totalSum = 0;
            double change = volume;
            int num = 0;
            while (true)
            {
                sum = Console.ReadLine();
                if (sum == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    Console.WriteLine("Statistic: {0} suitcases loaded.", num);
                    break;
                }
                nextSum = double.Parse(sum);
                if (nextSum < change)
                {
                    num++;
                    if (num % 3 == 0)
                    {
                        totalSum += nextSum + (nextSum * 10) / 100;
                    }
                    else
                    {
                        totalSum += nextSum;
                    }
                }
                if (nextSum > change)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine("Statistic: {0} suitcases loaded.", num);
                    break;
                }
                change = volume - totalSum;
            }
        }
    }
}
