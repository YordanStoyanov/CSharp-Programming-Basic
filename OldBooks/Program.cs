using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int num = 0;
            while (true)
            {
                num++;
                string book = Console.ReadLine();
                if (book == favoriteBook)
                {
                    Console.WriteLine("You checked {0} books and found it.", num - 1);
                    break;
                }
                else if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", num - 1);
                    break;
                }
                
            }

            /*
            if (favoriteBook is bool)
            {
                Console.WriteLine("You checked {0} books and found it.", num - 1);
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine("You checked {0} books.", num - 1);
            }
             */
        }
    }
}

/*
The Spot
Hunger Games
Harry Potter
Torronto
Spotify
No More Books
 */