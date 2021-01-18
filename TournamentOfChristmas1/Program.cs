using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOfChristmas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int wons = 0;
            int losses = 0;
            decimal money = 0m;
            decimal result = 0m;
            decimal total = 0m;
            int theDaysWons = 0;
            int theDaysLosses = 0;
            while (true)
            {
                if (num == 0)
                {
                    break;
                }

                while (true)
                {
                    
                    string sport = Console.ReadLine(); //problemat e che ne moje da se izbroyat vsichki sportove!!!
                    if (sport != "Finish")
                    {
                        string wonsLosses = Console.ReadLine();
                        if (wonsLosses == "win")
                        {
                            wons++;
                        }
                        else if (wonsLosses == "lose")
                        {
                            losses++;
                        }
                    }
                    else if (sport == "Finish")
                    {
                        if (wons > losses)
                        {
                            money = (decimal)wons * 20m + ((decimal)wons * 20m * 10m) / 100m;
                            theDaysWons++;
                        }
                        else if (wons < losses)
                        {
                            money = (decimal)wons * 20m;
                            theDaysLosses++;
                        }
                        result += money;
                    }
                    
                    if (sport == "Finish")
                    {
                        num--;
                        wons = 0;
                        losses = 0;
                        money = 0m;
                        break;
                    }
                }
            }

            if (theDaysWons > theDaysLosses)
            {
                total = result + (result * 20m) / 100m;
                Console.WriteLine("You won the tournament! Total raised money: {0:f2}", total);
            }
            else if (theDaysWons < theDaysLosses)
            {
                total = result;
                Console.WriteLine("You lost the tournament! Total raised money: {0:f2}", total);
            }
        }
    }
}

