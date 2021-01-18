using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCake = int.Parse(Console.ReadLine());
            string namesBaker = null;
            string point = null;
            string theGradestBaker = null;
            int result = 0;
            int maxResult = 0;
            int number = 0;
            int maxResult1 = 0;
            while (true)
            {
                namesBaker = Console.ReadLine();
                while (true)
                {
                    point = Console.ReadLine();
                    if (point != "Stop")
                    {
                        result += int.Parse(point);
                    }
                    else
                    {
                        Console.WriteLine("{0} has {1} points.", namesBaker, result);
                        number++;
                        maxResult = result;
                        if (maxResult1 < maxResult)
                        {
                            maxResult1 = maxResult;
                            theGradestBaker = namesBaker;
                            Console.WriteLine("{0} is the new number 1!", theGradestBaker);
                            
                        }
                        result = 0;
                        break;
                    }
                }

                if (numberCake == number)
                {
                    Console.WriteLine("{0} won competition with {1} points!", theGradestBaker, maxResult1);
                    break;
                }
            }
        }
    }
}
