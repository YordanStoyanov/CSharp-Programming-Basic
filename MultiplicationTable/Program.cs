using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while (true)
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", j, i, i * j);

                    if (i == 10)
                    {
                        j++;
                    }

                    if (j == 11)
                    {
                        return;
                    }
                }
            }
        }
    }
}
