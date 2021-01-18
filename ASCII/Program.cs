using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = null;
            int sum = 0;
            int biggest = 0;
            int biggest1 = 0;
            string word = null;
            while (true)
            {
                sum = 0;
                input = Console.ReadLine();
                if (input == "End of words")
                {
                    break;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    sum += (char)input[i];
                }

                if (input[0] == 'E' || input[0] == 'A' || input[0] == 'I' || input[0] == 'O' || input[0] == 'U' || input[0] == 'Y'
                    || input[0] == 'e' || input[0] == 'a' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u' || input[0] == 'y')
                {
                    
                    sum *= input.Length;
                    if (biggest < sum)
                    {
                        biggest = sum;
                        word = input;
                    }
                }
                else
                {
                    sum /= input.Length;
                    if (biggest < sum)
                    {
                        biggest = sum;
                        word = input;
                    }
                }
                biggest1 = biggest;
            }
            Console.WriteLine("The most powerful word is {0} - {1}", word, biggest1);
        }
    }
}
