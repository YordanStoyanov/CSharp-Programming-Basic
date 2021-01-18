using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberUnsatisfactoryAssessments = int.Parse(Console.ReadLine());

            while (true)
            {
                string task = Console.ReadLine();
                int rating = int.Parse(Console.ReadLine());
                if (task == "Enough")
                {
                    
                }
            }

            Console.WriteLine("Average score: {средна оценка}");
            Console.WriteLine("Number of problems: {броя на всички задачи}");
            Console.WriteLine("Last problem: {името на последната задача}");
            Console.WriteLine("You need a break, {брой незадоволителни оценки} poor grades.");

        }
    }
}
