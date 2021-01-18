using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vaucherPrice = decimal.Parse(Console.ReadLine());
            string purchases;
            decimal sum = 0;
            decimal total = 0;
            int p1 = 0;
            int p2 = 0;
            //Console.WriteLine("{брои закупени билети}");
            //Console.WriteLine("{брой закупени други покупки}");

            while (true)
            {
                purchases = Console.ReadLine();
                if (purchases == "End")
                {
                    break;
                }
                if (purchases.Length > 8)
                {
                    for (int i = 0; i < purchases.Length; i++)
                    {
                        
                        if (i == 2)
                        {
                            break;
                        }
                        sum += (char)purchases[i];
                    }
                    p1++;
                }
                else if (purchases.Length <= 8)
                {
                    for (int i = 0; i < purchases.Length; i++)
                    {
                        
                        if (i == 1)
                        {
                            break;
                        }
                        sum += (char)purchases[i];
                    }
                    p2++;
                }
                if (sum > vaucherPrice)
                {
                    break;
                }
                
            }
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
