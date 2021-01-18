using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double sum;
            if (oper == "+")
            {
                if ((N1 + N2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, oper, N2, N1 + N2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, oper, N2, N1 + N2);
                }
            }
            else if (oper == "-")
            {
                if ((N1 - N2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, oper, N2, N1 - N2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, oper, N2, N1 - N2);
                }
            }
            else if (oper == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    sum = (double)N1 / (double)N2;
                    Console.WriteLine("{0} {1} {2} = {3:F2}", N1, oper, N2, sum);
                }
            }
            else if (oper == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", N1, oper, N2, N1 % N2);
                }
            }
            else if (oper == "*")
            {
                if ((N1 * N2) % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", N1, oper, N2, N1 * N2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", N1, oper, N2, N1 * N2);
                }
            }
            
        }
    }
}
