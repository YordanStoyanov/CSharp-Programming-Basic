using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string weeksDay = Console.ReadLine();

            if (weeksDay == "Monday" || weeksDay == "Tuesday" || weeksDay == "Wednesday" || weeksDay == "Thursday" || weeksDay == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (weeksDay == "Saturday" || weeksDay == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
