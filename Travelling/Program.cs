using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = null;
            int total = 0;
            int needSum = 0;
            string sum = null;
            while (true)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                needSum = int.Parse(Console.ReadLine());
                
                while (total <= needSum)
                {
                    sum = Console.ReadLine();
                    if (sum == "End")
                    {
                        break;
                    }
                    int sum1 = int.Parse(sum);
                    total += sum1;
                }

                if (total >= needSum)
                {
                    Console.WriteLine("Going to {0}!", destination);
                    total = 0;
                }

            }
        }
    }
}
