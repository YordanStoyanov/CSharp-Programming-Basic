using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballResults
{
    public class FootballResults
    {
        public static void Main()
        {

                int firstGoal = int.Parse(Console.ReadLine());
                int secontGoal = int.Parse(Console.ReadLine());
                int wons = 0;
                int losses = 0;
                int drawn = 0;
                if (firstGoal > secontGoal)
                {
                    wons++;
                }
                else if (firstGoal < secontGoal)
                {
                    losses++;
                }
                else if (firstGoal == secontGoal)
                {
                    drawn++;
                }
                Console.WriteLine("Team won {0} games.", wons);
                Console.WriteLine("Team lost {0} games.", losses);
                Console.WriteLine("Drawn games: {0}", drawn);
        }
    }
}
