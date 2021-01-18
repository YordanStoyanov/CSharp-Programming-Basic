using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string Outfit = null;
            string Shoes = null;
            switch (partOfDay)
	        {
                case "Morning":
                    if (degrees >= 10 && degrees <= 18)
	                {
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
	                }
                    else if (degrees >= 18 && degrees <= 24)
	                {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
		 
	                }
                    else if (degrees >= 25)  
	                {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
	                }
                        break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
	                {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
	                }
                    else if (degrees >= 18 && degrees <= 24)
	                {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
		 
	                }
                    else if (degrees >= 25)  
	                {
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
	                }
                    break;
                case "Evening":
                    if (degrees >= 10 && degrees <= 18)
	                {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
	                }
                    else if (degrees >= 18 && degrees <= 24)
	                {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
		 
	                }
                    else if (degrees >= 25)  
	                {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
	                }
                    break;
	        }
            Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
        }
    }
}
