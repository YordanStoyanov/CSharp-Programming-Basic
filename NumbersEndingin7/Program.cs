using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NumbersEndingin7
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 7; i < 1000; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int num = int.Parse(Console.ReadLine());
            //
            //int maxNum = 0;
            //int minNum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //    maxNum = array.Min();
            //    minNum = array.Max();
            //}
            //Console.WriteLine("Max number: {0}", maxNum);
            //Console.WriteLine("Min number: {0}", minNum);

            double numbers = double.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            for (int i = 0; i < numbers; i++)
            {
                double evenOdd = double.Parse(Console.ReadLine());

                if (evenOdd % 2 == 0)
                {
                    evenSum += evenOdd;
                    if (evenOdd > evenMax)
                    {
                        evenMax = evenOdd;
                    }
                    else
                    {
                        Console.WriteLine("EvenMax=No");
                    }

                    if (evenOdd < evenMin)
                    {
                        evenMin = evenOdd;
                    }
                    else
                    {
                        Console.WriteLine("EvenMin=No");
                    }
                }

                if (evenOdd % 2 != 0)
                {
                    oddSum += evenOdd;
                    if (evenOdd > oddMax)
                    {
                        oddMax = evenOdd;
                    }
                    else
                    {
                        Console.WriteLine("OddMax=No");
                    }

                    if (evenOdd < oddMin)
                    {
                        oddMin = evenOdd;
                    }
                    else
                    {
                        Console.WriteLine("EvenMax=No");
                    }

                }
            }
            Console.WriteLine("OddSum={0:f2},", oddSum);
            Console.WriteLine("OddMin={0:f2},", oddMin);
            Console.WriteLine("OddMax={0:f2},", oddMax);
            Console.WriteLine("EvenSum={0:f2},", evenSum);
            Console.WriteLine("EvenMin={0:f2},", evenMin);
            Console.WriteLine("EvenMax={0:f2}", evenMax);
        }
    }
}
