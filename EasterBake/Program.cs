using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cake = int.Parse(Console.ReadLine());
            int sugar = 0;
            int flour = 0;
            int totalSugar = 0;
            int totalFlour = 0;
            int maxSugar = 0;
            int maxFlour = 0;
            for (int i = 0; i < cake; i++)
            {
                sugar = int.Parse(Console.ReadLine());
                flour = int.Parse(Console.ReadLine());
                totalSugar += sugar;
                totalFlour += flour;
                if (maxSugar < sugar)
                {
                    maxSugar = sugar;
                }

                if (maxFlour < flour)
                {
                    maxFlour = flour;
                }
            }

            Console.WriteLine("Sugar: {0}", Math.Ceiling(totalSugar / 950m));
            Console.WriteLine("Flour: {0}", Math.Ceiling(totalFlour / 750m));
            Console.WriteLine("Max used flour is {0} grams, max used sugar is {1} grams.", maxFlour, maxSugar);
        }
    }
}
