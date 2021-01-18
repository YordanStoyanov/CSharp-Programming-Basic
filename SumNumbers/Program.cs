using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < num; i++)
        {
            int sum = int.Parse(Console.ReadLine());
            result += sum;
        }

        Console.WriteLine(result);
    }
}

