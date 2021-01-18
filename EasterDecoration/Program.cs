using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientNumer = int.Parse(Console.ReadLine());
            string product = null;
            decimal basket = 0m;
            decimal wreath = 0m;
            decimal chocolateBunny = 0m;
            int number = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            decimal result = 0m;
            decimal totalResult = 0m;
            while (true)
            {
                
                
                while (true)
                {
                    product = Console.ReadLine();
                    if (product == "basket")
                    {
                        basket = 1.5m;
                        p1++;
                    }
                    else if (product == "wreath")
                    {
                        wreath = 3.8m;
                        p2++;
                    }
                    else if (product == "chocolate bunny")
                    {
                        chocolateBunny = 7m;
                        p3++;
                    }else if (product == "Finish")
                    {
                        number++;
                        decimal p = (decimal)p1 + (decimal)p2 + (decimal)p3;
                        if (p % 2 == 0)
                        {
                            result = ((decimal)p1 * basket + (decimal)p2 * wreath + (decimal)p3 * chocolateBunny) - (((decimal)p1 * basket + (decimal)p2 * wreath + (decimal)p3 * chocolateBunny) * 20m) / 100m;
                            Console.WriteLine("You purchased {0} items for {1:F2} leva.", p, result);
                        }
                        else
                        {
                            result = ((decimal)p1 * basket + (decimal)p2 * wreath + (decimal)p3 * chocolateBunny);
                            Console.WriteLine("You purchased {0} items for {1:F2} leva.", p, result);
                        }
                    }


                    if (product == "Finish")
                    {
                        totalResult += result;
                        p1 = 0;
                        p2 = 0;
                        p3 = 0;
                    }

                    
                    if (clientNumer == number)
                    {
                        break;
                    }
                }

                if (clientNumer == number)
                {
                    Console.WriteLine("Average bill per client is: {0:f2} leva.", totalResult / (decimal)clientNumer);
                    break;
                }
            }
        }
    }
}
