using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                if (sum < num)
                {
                    int num1 = int.Parse(Console.ReadLine());
                    sum += num1; 
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
