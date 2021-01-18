using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int row = 0;
            int col = 0;
            int current = 0;
            for (row = 1; row <= num; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    current++;
                    Console.Write(current + " ");
                    
                    if (current >= num)
                    {
                        break;
                    }
                }
                if (current >= num)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}

