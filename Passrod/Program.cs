using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passrord
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != pass)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}!", user);
        }
    }
}
