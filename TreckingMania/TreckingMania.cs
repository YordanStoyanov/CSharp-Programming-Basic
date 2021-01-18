using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TreckingMania
{
    public class TreckingMania
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 5)
            {
                int mussala = int.Parse(Console.ReadLine());
                int monblan = int.Parse(Console.ReadLine());
                int kilimandhzaro = int.Parse(Console.ReadLine());
                int k2 = int.Parse(Console.ReadLine());
                int everest = int.Parse(Console.ReadLine());
                int sum = mussala + monblan + kilimandhzaro + k2 + everest;
                double percentForMussala = ((double)mussala / (double)sum) * 100;
                double percentForMonblan = ((double)monblan / (double)sum) * 100;
                double percentForKilimandhzaro = ((double)kilimandhzaro / (double)sum) * 100;
                double percentForK2 = ((double)k2 / (double)sum) * 100;
                double percentForEverest = ((double)everest / (double)sum) * 100;
                Console.WriteLine("{0:f2}%",percentForMussala);
                Console.WriteLine("{0:f2}%",percentForMonblan);
                Console.WriteLine("{0:f2}%",percentForKilimandhzaro);
                Console.WriteLine("{0:f2}%",percentForK2);
                Console.WriteLine("{0:f2}%",percentForEverest);
            }
            
        }
    }
}
