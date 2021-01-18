using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal theHallRent = decimal.Parse(Console.ReadLine());

            decimal cake = (theHallRent * 20m) / 100m;
            decimal drinks = cake - (cake * 45m) / 100m;
            decimal animator = theHallRent / 3m;
            decimal result = theHallRent + cake + drinks + animator;
            Console.WriteLine(result);
        }
    }
}
