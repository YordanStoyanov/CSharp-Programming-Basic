using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeTicket = Console.ReadLine();
            int rRows = int.Parse(Console.ReadLine());
            int cCows = int.Parse(Console.ReadLine());
            decimal ticketPrice = 0m;
            if (typeTicket == "Premiere")
            {
                ticketPrice = 12.00m;
            }
            else if (typeTicket == "Normal")
            {
                ticketPrice = 7.50m;
            }
            else if (typeTicket == "Discount")
            {
                ticketPrice = 5.00m;
            }
            decimal result = ticketPrice * (decimal)rRows * (decimal)cCows;
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
