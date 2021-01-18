using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs = int.Parse(Console.ReadLine());
            string color = null;
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            int maxNumberOfEggs = 0;
            string colorOfMaxNumber = null;
            while (true)
            {
                color = Console.ReadLine();
                if (color == "red")
                {
                    red++;
                }
                else if (color == "orange")
                {
                    orange++;
                }
                else if (color == "blue")
                {
                    blue++;
                }
                else if (color == "green")
                {
                    green++;
                }

                
                numberOfEggs--;
                if (numberOfEggs == 0)
                {
                    break;
                }
            }

            if (maxNumberOfEggs < red)
            {
                maxNumberOfEggs = red;
                colorOfMaxNumber = "red";
            }
            
            if (maxNumberOfEggs < orange)
            {
                maxNumberOfEggs = orange;
                colorOfMaxNumber = "orange";
            }
            
            if (maxNumberOfEggs < blue)
            {
                maxNumberOfEggs = blue;
                colorOfMaxNumber = "blue";
            }
            
            if (maxNumberOfEggs < green)
            {
                maxNumberOfEggs = green;
                colorOfMaxNumber = "green";
            }

            Console.WriteLine("Red eggs: {0}", red);
            Console.WriteLine("Orange eggs: {0}", orange);
            Console.WriteLine("Blue eggs: {0}", blue);
            Console.WriteLine("Green eggs: {0}", green);
            Console.WriteLine("Max eggs: {0} -> {1}", maxNumberOfEggs, colorOfMaxNumber);
        }
    }
}
