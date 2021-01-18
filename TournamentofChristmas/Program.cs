using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentofChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int wons = 0;
            int losses = 0;
            decimal money = 0m;
            for (int i = 0; i < num; num--)
            {
                if (num % 2 == 0)
                {
                    string sport = Console.ReadLine();
                    while (sport != "Finish")
                    {
                        if (sport == "volleyball")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "football")
                        {

                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "basketball")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "golf")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "tennis")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "badminton")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "darts")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "handball")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "judo")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                            
                        }
                        else if (sport == "snooker")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }
                        }
                        else if (sport == "swimming")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            } 
                        }
                        else if (sport == "squash")
                        {
                            string winLoss = Console.ReadLine();
                            if (winLoss == "win")
                            {
                                wons += 1;
                            }
                            else if (winLoss == "lose")
                            {
                                losses += 1;
                            }  
                        }

                        if (wons > losses)
                        {
                            money = ((decimal)wons * 20m * 10m) / 100m;
                        }
                    }

                    if (num % 2 != 0)
                    {
                        while (sport != "Finish")
                        {
                            if (sport == "volleyball")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "football")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "basketball")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "golf")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "tennis")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "badminton")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "darts")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "handball")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "judo")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }

                            }
                            else if (sport == "snooker")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "swimming")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }
                            else if (sport == "squash")
                            {
                                string winLoss = Console.ReadLine();
                                if (winLoss == "win")
                                {
                                    wons += 1;
                                }
                                else if (winLoss == "lose")
                                {
                                    losses += 1;
                                }
                            }

                            if (wons > losses)
                            {
                                money = ((decimal)wons * 20m * 10m) / 100m;
                            }
                        }
                    }
                }
            }

            if (wons > losses)
            {
                money = ((decimal)wons * 20m * 20m) / 100m;
                Console.WriteLine("You won the tournament! Total raised money: {0}", money);
            }
            else
            {
                money = (decimal)wons * 20m;
                Console.WriteLine("You lost the tournament! Total raised money: {}", money);
            }

        }
    }
}
