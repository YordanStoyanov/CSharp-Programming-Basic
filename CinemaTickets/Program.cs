using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string moviesName = null;
            double freeSits = 0;
            string ticketsType = null;
            double totalSits = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double m1 = 0;
            double m2 = 0;
            double m3 = 0;
            while (true)
            {
                moviesName = Console.ReadLine();
                freeSits = double.Parse(Console.ReadLine());
                totalSits = freeSits;
                m1 = 0;
                m2 = 0;
                m3 = 0;
                while (true)
                {
                    ticketsType = Console.ReadLine();

                    if (freeSits == 0)
                    {
                        Console.WriteLine("{0} - {1:F2}% full.", moviesName, 100);
                        break;
                    }

                    if (ticketsType == "End" || ticketsType == "Finish" )
                    {
                        Console.WriteLine("{0} - {1:F2}% full.", moviesName, ((m1 + m2 + m3) / totalSits) * 100);
                        break;
                    }

                    if (ticketsType == "student")
                    {
                        p1++; m1++; freeSits--;
                    }
                    else if (ticketsType == "standard")
                    {
                        p2++; m2++; freeSits--;
                    }
                    else if (ticketsType == "kid")
                    {
                        p3++; m3++; freeSits--;
                    }

                    
                }

                if (ticketsType == "Finish")
                {
                    break;
                }
            }
            Console.WriteLine("Total tickets: {0}", (p1 + p2 + p3));
            Console.WriteLine("{0:F2}% student tickets.", (p1 / (p1 + p2 + p3)) * 100);
            Console.WriteLine("{0:F2}% standard tickets.", (p2 / (p1 + p2 + p3)) * 100);
            Console.WriteLine("{0:f2}% kids tickets.", (p3 / (p1 + p2 + p3)) * 100);
        }
    }
}
