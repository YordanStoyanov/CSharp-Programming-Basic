using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double numberOfPagesPecHour = double.Parse(Console.ReadLine());
            int numberOfDaysForABook = int.Parse(Console.ReadLine());

            double numberOfHour = (double)numberOfPages / numberOfPagesPecHour;
            double numberOfHourPecDay = numberOfHour / (double)numberOfDaysForABook;
            Console.WriteLine("{0}", numberOfHourPecDay);
        }
    }
}
