using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (sex == "m")
            {
                if (number >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else if (number < 16)
                {
                    Console.WriteLine("Master");
                }
            }
            else if (sex  == "f")
            {
                if (number >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else if (number < 16)
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
