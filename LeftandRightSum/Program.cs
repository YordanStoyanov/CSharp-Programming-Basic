using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < num; num--)
			{
                if (num % 2 == 0)
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    sum1 = num1 + num2;
                }
                else if (num % 2 != 0)
                {
                    int num3 = int.Parse(Console.ReadLine());
                    int num4 = int.Parse(Console.ReadLine());
                    sum2 = num3 + num4;
                }
			 
			}

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }

            if (sum1 > sum2) 
            {
                Console.WriteLine("No, diff = {0}", sum1 - sum2);
            }
            else if (sum1 < sum2 )
            {
                Console.WriteLine("No, diff = {0}", sum2 - sum1);
            }
        }
    }
}
