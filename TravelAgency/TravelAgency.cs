using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class TravelAgency
    {
        public static void Main()
        {
            string city = Console.ReadLine();
            string packageType = Console.ReadLine();
            string yesOrNoForVIP = Console.ReadLine();
            int staingDays = int.Parse(Console.ReadLine());
            decimal withEquipment = 0m;
            decimal noEquipment = 0m;
            decimal withBreakfast = 0m;
            decimal noBreakfast = 0m;
            decimal vip = 0m;
            decimal result = 0m;
            switch (city)
            {
                case "Bansko":
                    if (packageType == "withEquipment")
                    {
                        withEquipment = 100m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = withEquipment - withEquipment * (10m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = withEquipment;
                        }
                    }
                    else if (packageType == "noEquipment")
                    {
                        noEquipment = 80m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = noEquipment - noEquipment * (5m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = noEquipment;
                        }
                    }
                    break;
                case "Borovets":
                    if (packageType == "withEquipment")
                    {
                        withEquipment = 100m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = withEquipment - withEquipment * (10m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = withEquipment;
                        }
                    }
                    else if (packageType == "noEquipment")
                    {
                        noEquipment = 80m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = noEquipment - noEquipment * (5m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = noEquipment;
                        }
                    }
                    break;
                case  "Varna":
                    if (packageType == "withBreakfast")
                    {
                        withBreakfast = 130m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = withBreakfast - withBreakfast * (12m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = withBreakfast;
                        }
                    }
                    else if (packageType == "noBreakfast")
                    {
                        noBreakfast = 100m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = noBreakfast - noBreakfast * (7m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = noBreakfast;
                        }
                    }
                    break;
                case "Burgas":
                    if (packageType == "withBreakfast")
                    {
                        withBreakfast = 130m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = withBreakfast - withBreakfast * (12m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = withBreakfast;
                        }
                    }
                    else if (packageType == "noBreakfast")
                    {
                        noBreakfast = 100m;
                        if (yesOrNoForVIP == "yes")
                        {
                            vip = noBreakfast - noBreakfast * (7m / 100m);
                        }
                        else if (yesOrNoForVIP == "no")
                        {
                            vip = noBreakfast;
                        }
                    }
                    break;
            }
            result = vip * (decimal)staingDays;
            if (city != "Bansko" && city != "Borovets" && city != "Varna" && city != "Burgas")
            {
                Console.WriteLine("Invalid input!");
            }
            else if (staingDays < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                Console.WriteLine("The price is {0:f2}lv! Have a nice time!", result);
            }
        }
    }
}
