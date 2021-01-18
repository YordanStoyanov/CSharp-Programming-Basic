using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int smart = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            
            if (smart >= 80 && power >= 80 && sex == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (smart >= 80 && power <= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (smart >= 60 && smart <= 80)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if (smart < 80 && power >= 80 && sex == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (power < 80 && power >= 60 && smart < 80)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }

        }
    }
}
