using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int min = numbers[0];
            int max = numbers[1];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Max number: {0}", max);
            Console.WriteLine("Min number: {0}", min);
        }
    }
}
