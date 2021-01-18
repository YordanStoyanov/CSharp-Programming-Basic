using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieNumbers = int.Parse(Console.ReadLine());
            string movieName = null;
            double movieRatings = 0;
            double biggestRating = 0;
            double smallestRating = 0;
            double middleRating = 0;
            string movie1 = null;
            string movie2 = null;
                for (int i = 1; i <= movieNumbers; i++)
                {
                    movieName = Console.ReadLine();
                    movieRatings = double.Parse(Console.ReadLine());

                    if (biggestRating < movieRatings)
                    {
                        biggestRating = movieRatings;
                        movie1 = movieName;
                    }
                    
                    if (biggestRating > movieRatings)
                    {
                        smallestRating = movieRatings;
                        movie2 = movieName;
                    }

                    middleRating += movieRatings;
                }
                Console.WriteLine("{0} is with highest rating: {1:f1}", movie1, biggestRating);
                Console.WriteLine("{0} is with lowest rating: {1:f1}", movie2, smallestRating);
                Console.WriteLine("Average rating: {0:f1}", middleRating / movieNumbers);
        }
    }
}
