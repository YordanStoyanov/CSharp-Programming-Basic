using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    public class Program
    {
        public static void Main()
        {
            string durationOfContract = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileInternetYesOrNo = Console.ReadLine();
            int numberOfMonths = int.Parse(Console.ReadLine());
            decimal fee = 0m;
            if (durationOfContract == "one")
            {
                if (contractType == "Small")
                {
                    fee = 9.98m;
                }
                else if (contractType == "Middle")
                {
                    fee = 18.99m;
                }
                else if (contractType == "Large")
                {
                    fee = 25.98m;
                }
                else if (contractType == "ExtraLarge")
                {
                    fee = 35.99m;
                }

                if (mobileInternetYesOrNo == "yes")
                {
                    if (fee <= 10m)
                    {
                        fee += 5.50m;
                    }
                    else if (fee > 10m && fee <= 30m)
                    {
                        fee += 4.35m;
                    }
                    else if (fee > 30m)
                    {
                        fee += 3.85m;
                    }
                }
            }
            else if (durationOfContract == "two")
            {
                if (contractType == "Small")
                {
                    fee = 8.58m;
                }
                else if (contractType == "Middle")
                {
                    fee = 17.09m;
                }
                else if (contractType == "Large")
                {
                    fee = 23.59m;
                }
                else if (contractType == "ExtraLarge")
                {
                    fee = 31.79m;
                }

                if (mobileInternetYesOrNo == "yes")
                {
                    if (fee <= 10m)
                    {
                        fee += 5.50m;
                    }
                    else if (fee > 10m && fee <= 30m)
                    {
                        fee += 4.35m;
                    }
                    else if (fee > 30m)
                    {
                        fee += 3.85m;
                    }
                }
                fee = fee - (fee * 3.75m) / 100m;
            }
            Console.WriteLine("{0:f2} lv.", fee * (decimal)numberOfMonths);
        }
    }
}
