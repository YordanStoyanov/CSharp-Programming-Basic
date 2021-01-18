using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honey
{
    class Program
    {
        static void Main(string[] args)
        {
            int etadAmoundOfHoney = int.Parse(Console.ReadLine());
            string bees = null;
            double amoundOfHoney = 0;
            double sumAmundOfHoney = 0;
            string theBeesName = null;
            while (true)
            {
                bees = Console.ReadLine();
                theBeesName = bees;
                if (bees == "Winter has come")
                {
                    break;
                }

                for (int i = 0; i < 6; i++)
                {
                    amoundOfHoney = double.Parse(Console.ReadLine());
                    sumAmundOfHoney += amoundOfHoney;
                }

                if (sumAmundOfHoney < 0)
                {
                    Console.WriteLine("{0} was banished for gluttony", theBeesName);
                }else if (sumAmundOfHoney < etadAmoundOfHoney)
                {
                    Console.WriteLine("Hard Winter! Honey needed {0:F2}.", etadAmoundOfHoney - sumAmundOfHoney);
                }
                else if (sumAmundOfHoney > amoundOfHoney)
                {
                    Console.WriteLine("Well done! Honey surplus {0:f2}.", sumAmundOfHoney - etadAmoundOfHoney);
                }
            }
        }
    }
}
/*
300
Beeatrice
50
-10
40
30
100
100 
Winter has come
 */

/*
1000
Maya
50
10.5
19.5
30
100
100
Winter has come
 */