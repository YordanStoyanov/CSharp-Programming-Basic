using System;

class GFG
{

    // Function to compute the sum of ASCII  
    // values of each word separated by a  
    // space and return the total sum of 
    // the ASCII values, excluding the space. 
    static long ASCIIWordSum(String str, long[] sumArr)
    {
        int l = str.Length;
        int pos = 0;
        long sum = 0;
        long bigSum = 0;
        for (int i = 0; i < l; i++)
        {

            // Separate each word by 
            // a space and store values 
            // corresponding to each word 
            if (str[i] == ' ')
            {
                bigSum += sum;
                sumArr[pos++] = sum;
                sum = 0;
            }
            else

                // Implicit type casting 
                sum += str[i];
        }

        // Storing the sum of last word 
        sumArr[pos] = sum;
        bigSum += sum;
        return bigSum;
    }

    // Driver function 
    public static void Main()
    {
        String str = Console.ReadLine();

        // Counting the number of words 
        // in the input sentence 
        int ctr = 0;
        for (int i = 0; i < str.Length; i++)
            if (str[i] == ' ')
                ctr++;

        long[] sumArr = new long[ctr + 1];

        // Calling function 
        long sum = ASCIIWordSum(str, sumArr);

        // Printing equivalent sum of 
        // the words in the sentence 
        Console.WriteLine("Sum of ASCII values:");
        for (int i = 0; i <= ctr; i++)
            Console.Write(sumArr[i] + " ");

        Console.WriteLine();
        Console.Write("Total sum -> " + sum);
        Console.WriteLine();

        

    }
}