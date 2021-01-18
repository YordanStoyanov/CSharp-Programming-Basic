using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0;
            decimal amount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "NoMoreMoney")
                {
                    amount = decimal.Parse(input);
                    if (amount < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        break;
                        
                    }
                    else if (amount > 0)
                    {
                        Console.WriteLine("Increase: {0:f2}", amount);
                        total += amount;
                    }
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("Total: {0:f2}", total);
        }
    }
}
