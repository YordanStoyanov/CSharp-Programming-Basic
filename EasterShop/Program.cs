using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs = int.Parse(Console.ReadLine());
            int sold = 0;
            
            while (true)
            {
                string buyFill = Console.ReadLine();

                if (buyFill == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine("{0} eggs sold.", sold);
                    break;
                }

                int buyOrFill = int.Parse(Console.ReadLine());

                if (buyFill == "Buy")
                {
                    if (numberOfEggs < buyOrFill)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine("You can buy only {0}.", numberOfEggs);
                        break;
                    }
                    else
                    {
                        numberOfEggs -= buyOrFill;
                        sold += buyOrFill;
                    }
                }
                else if (buyFill == "Fill")
                {
                    numberOfEggs += buyOrFill;
                }
                
            }
        }
    }
}
