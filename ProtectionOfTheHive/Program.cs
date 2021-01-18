using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectionOfTheHive
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBees = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());
            int bearAttack = numberOfBees - attack;
            int beesConterAttack = health - bearAttack * 5;
            int bearAttackAgein = bearAttack - attack;
            int bearDeathOrLive = beesConterAttack - bearAttackAgein * 5;
            if (bearDeathOrLive < 0)
            {
                Console.WriteLine("Beehive won! Bees left {0}.", bearAttackAgein);
            }
            
            if (bearAttackAgein < 100  && beesConterAttack > 0)
            {
                Console.WriteLine("The bear stole the honey! Bees left {0}.", bearAttackAgein);
            }
            else if (beesConterAttack < 0)
            {
                Console.WriteLine("The bear stole the honey! Bees left {0}.", 0);
            }
            
        }
    }
}
