using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            decimal comission = 0m;
            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = ((decimal)sales * 5m) / 100m;
                }
                else if (sales >= 500 && sales <= 1000)
                {

                    comission = ((decimal)sales * 7m) / 100m;
                }
                else if (sales >= 1000 && sales <= 10000)
                {

                    comission = ((decimal)sales * 8m) / 100m;
                }
                else if (sales > 10000)
                {

                    comission = ((decimal)sales * 12m) / 100m;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = ((decimal)sales * 4.5m) / 100m;
                }
                else if (sales >= 500 && sales <= 1000)
                {

                    comission = ((decimal)sales * 7.5m) / 100m;
                }
                else if (sales >= 1000 && sales <= 10000)
                {

                    comission = ((decimal)sales * 10m) / 100m;
                }
                else if (sales > 10000)
                {

                    comission = ((decimal)sales * 13m) / 100m;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = ((decimal)sales * 5.5m) / 100m;
                }
                else if (sales >= 500 && sales <= 1000)
                {

                    comission = ((decimal)sales * 8m) / 100m;
                }
                else if (sales >= 1000 && sales <= 10000)
                {

                    comission = ((decimal)sales * 12m) / 100m;
                }
                else if (sales > 10000)
                {

                    comission = ((decimal)sales * 14.5m) / 100m;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
	        }

            if (comission > 0)
            {
                Console.WriteLine("{0:f2}", comission);
            }
        }
    }
}
