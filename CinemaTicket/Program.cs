using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string weeksDay = Console.ReadLine();

            if (weeksDay == "Monday")
            {
                Console.WriteLine(12);
            }
            else if (weeksDay == "Tuesday")
            {
                Console.WriteLine(12);
            }
            else if (weeksDay == "Wednesday")
            {
                Console.WriteLine(14);
            }
            else if (weeksDay == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (weeksDay == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (weeksDay == "Saturday")
            {
                Console.WriteLine(16);
            }
            else if (weeksDay == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
