using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = null;
            int primeNUmbers = 0;
            int nonPrimeNumbers = 0;
            
            while (true)
            {
                num = Console.ReadLine();
                if (num == "stop")
                {
                    break;
                }
                int number = int.Parse(num);
                if (number >= 0)
                {
                    if (number == 1 || number == 2 || number == 3 || number == 5 || number == 7
                        || number == 11 || number == 13 || number == 17 || number == 19 || number == 23
                        || number == 27 || number == 31 || number ==  37 || number == 41 || number == 43
                        || number == 47 || number == 53 || number == 59 || number == 61 || number == 67
                        || number == 71 || number == 73 || number == 79 || number == 83 || number == 89
                        || number == 97 || number == 101)
                    {
                        primeNUmbers += number;
                    }
                    else
                    {
                        nonPrimeNumbers += number;
                    }
                }

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
            }
            Console.WriteLine("Sum of all prime numbers is: {0}", primeNUmbers);
            Console.WriteLine("Sum of all non prime numbers is: {0}", nonPrimeNumbers);
        }
    }
}
