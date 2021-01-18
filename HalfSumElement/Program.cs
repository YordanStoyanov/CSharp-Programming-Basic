using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int max = numbers[0];
            int min = numbers[1];
            int sumMin = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (max < numbers[i])
                {
                    max = numbers[i];
                }

                if (min > numbers[i])
                {
                    min += numbers[i];
                }

                if (min < max)
                {
                    sumMin += min;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(sumMin);
        }
    }
}