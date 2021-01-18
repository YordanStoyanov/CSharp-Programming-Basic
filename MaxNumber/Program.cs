using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallNumber = int.MaxValue;
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "Stop")
                {
                    break;
                }
                int number = int.Parse(num);
                if (smallNumber > number)
                {
                    smallNumber = number;
                }
            }
            Console.WriteLine(smallNumber);
        }
    }
}
