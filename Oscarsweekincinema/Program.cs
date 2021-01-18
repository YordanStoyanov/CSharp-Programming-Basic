using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscarsweekincinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmsName = Console.ReadLine();
            string typeHoll = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            decimal price = 0m;
            if (filmsName == "A Star Is Born")
            {
                if (typeHoll == "normal")
                {
                    price = 7.50m;
                }
                else if (typeHoll == "luxury")
                {
                    price = 10.50m;
                }
                else if (typeHoll == "ultra luxury")
                {
                    price = 13.50m;
                }
            }
            else if (filmsName == "Bohemian Rhapsody")
            {
                if (typeHoll == "normal")
                {
                    price = 7.35m;
                }
                else if (typeHoll == "luxury")
                {
                    price = 9.45m;
                }
                else if (typeHoll == "ultra luxury")
                {
                    price = 12.75m;
                }
            }
            else if (filmsName == "Green Book")
            {
                if (typeHoll == "normal")
                {
                    price = 8.15m;
                }
                else if (typeHoll == "luxury")
                {
                    price = 10.25m;
                }
                else if (typeHoll == "ultra luxury")
                {
                    price = 13.25m;
                }
            }
            else if (filmsName == "The Favourite")
            {
                if (typeHoll == "normal")
                {
                    price = 8.75m;
                }
                else if (typeHoll == "luxury")
                {
                    price = 11.55m;
                }
                else if (typeHoll == "ultra luxury")
                {
                    price = 13.95m;
                }
            }
            Console.WriteLine("{0} -> {1:f2} lv.", filmsName, (decimal)numberOfTickets * price);
        }
    }
}
