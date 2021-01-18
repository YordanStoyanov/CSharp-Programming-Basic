using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int OddSum = 0;
            int EvenSum = 0;
            int evenMax = 0;
            int evenMin = 0;
            int OddMax = 0;
            int OddMin = 0;
            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    OddSum += number;
                    if (OddMin > number)
                    {
                        OddMin = number;
                    }

                    if (OddMax < number)
                    {
                        OddMax = number;
                    }
                }

                if (number % 2 == 0)
                {
                    EvenSum += number;
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }

                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                }
            }

            Console.WriteLine("OddSum={0:f2},", OddSum);
            Console.WriteLine("OddMin={0:f2},", OddMin);
            Console.WriteLine("OddMax={0:f2},", OddMax);
            Console.WriteLine("EvenSum={0:f2},", EvenSum);
            Console.WriteLine("EvenMin={0:f2},", evenMin);
            Console.WriteLine("EvenMax={0:f2}", evenMax);
        }
    }
}
