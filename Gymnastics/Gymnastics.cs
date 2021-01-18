using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastics
{
    public class Gymnastics
    {
        public static void Main()
        {
            string contry = Console.ReadLine();
            string device = Console.ReadLine();
            double maxRate = 20;
            double difficultyRussia = 0;
            double executionRussia = 0;
            
            if (contry == "Bulgaria")
            {
                switch (device)
                {
                    case "ribbon":
                        difficultyRussia = 9.600;
                        executionRussia = 9.400;
                        break;
                    case "hoop":
                        difficultyRussia = 9.550;
                        executionRussia = 9.750;
                        break;
                    case "rope":
                        difficultyRussia = 9.500;
                        executionRussia = 9.400;
                        break;

                }
                double rating = difficultyRussia + executionRussia; 
            }
            else if (contry == "Russia")
            {
                switch (device)
                {
                    case "ribbon":
                        difficultyRussia = 9.100;
                        executionRussia = 9.400;
                        break;
                    case "hoop":
                        difficultyRussia = 9.300;
                        executionRussia = 9.800;
                        break;
                    case "rope":
                        difficultyRussia = 9.600;
                        executionRussia = 9.000;
                        break;

                }
                double rating = difficultyRussia + executionRussia;
            }
            else if (contry == "Italy")
            {
                switch (device)
                {
                    case "ribbon":
                        difficultyRussia = 9.200;
                        executionRussia = 9.500;
                        break;
                    case "hoop":
                        difficultyRussia = 9.450;
                        executionRussia = 9.350;
                        break;
                    case "rope":
                        difficultyRussia = 9.700;
                        executionRussia = 9.150;
                        break;

                }
                double rating = difficultyRussia + executionRussia; 
            }
            double changeLeftPercent = ((maxRate - (difficultyRussia + executionRussia)) / maxRate) * 100;
            Console.WriteLine("The team of {0} get {1:f3} on {2}.", contry, difficultyRussia + executionRussia, device);
            Console.WriteLine("{0:f2}%", changeLeftPercent);
        }

    }
}

