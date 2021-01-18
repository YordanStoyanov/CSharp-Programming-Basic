using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    p1++;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    p2++;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    p3++;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    p4++;
                }
                else if (numbers >= 800)
                {
                    p5++;
                }
            }

            p1 = (p1 / num) * 100;
            p2 = (p2 / num) * 100;
            p3 = (p3 / num) * 100;
            p4 = (p4 / num) * 100;
            p5 = (p5 / num) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
