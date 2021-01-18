using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i <= n; n--)
            //{
            //    Console.WriteLine(n);
            //}

            //int n = int.Parse(Console.ReadLine());
            //
            //for (int i = 1; i <= n; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //string name = Console.ReadLine();
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //string str = Console.ReadLine();
            //int sum = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    sum += (int)str[i];
            //}
            //Console.WriteLine(sum);
            string str = Console.ReadLine();
            int sum = 0;
            
            for (int j = 0; j < str.Length; j++)
            {
                if (str == "a")
                {
                    sum += 1;
                }
                
                if (str == "0")
                {
                    sum += 4;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
