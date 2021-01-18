using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double totalNum = num;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            while (num != 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1++;
                }

                if (number % 3 == 0)
                {
                    p2++;
                }

                if (number % 4 == 0)
                {
                    p3++;
                }
                num--;
            }
            Console.WriteLine("{0:f2}%", (p1 / totalNum) * 100);
            Console.WriteLine("{0:f2}%", (p2 / totalNum) * 100);
            Console.WriteLine("{0:f2}%", (p3 / totalNum) * 100);
        }
    }
}
