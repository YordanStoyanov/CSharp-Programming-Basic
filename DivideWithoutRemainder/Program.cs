using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < num; i++)
            {
                double number = double.Parse(Console.ReadLine());
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
            }
            p1 = (p1 / num) * 100;
            p2 = (p2 / num) * 100;
            p3 = (p3 / num) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
