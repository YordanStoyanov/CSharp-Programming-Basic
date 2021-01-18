using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            while (true)
            {
                for (i = 0; i <= 59; i++)
                {
                    Console.WriteLine("{0}:{1}", j, i);

                    if (i == 59)
                    {
                        j++;
                    }
                    
                    if (j == 24)
                    {
                        return;
                    }
                }
            }
        }
    }
}
