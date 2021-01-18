using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int numberOfWalking = int.Parse(Console.ReadLine());
            int calPedDay = int.Parse(Console.ReadLine());
            int walkinePedDay = min * numberOfWalking;
            int combCalPedDay = walkinePedDay * 5;
            int fiftheenPerCent = (calPedDay * 50) / 100;
            if (combCalPedDay > fiftheenPerCent)
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0}.", combCalPedDay); 
            }
            else
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0}.", combCalPedDay);
            }
        }
    }
}
