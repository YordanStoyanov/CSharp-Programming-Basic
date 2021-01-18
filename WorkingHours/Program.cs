using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string weeksDay = Console.ReadLine();

            if (number >= 10 && number <= 18)
            {
                if (weeksDay == "Monday" || weeksDay == "Tuesday" || weeksDay == "Wednesday" || weeksDay == "Thursday" || weeksDay == "Friday" || weeksDay == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else if (weeksDay == "Sunday")
                {
                    Console.WriteLine("closed");
                }
            }
            else if (number < 10 || number > 18)
            {
                    Console.WriteLine("closed");
            }
        }
    }
}
