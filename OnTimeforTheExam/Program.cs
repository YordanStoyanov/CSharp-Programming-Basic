using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeforTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examsTime = int.Parse(Console.ReadLine());
            int examsMin = int.Parse(Console.ReadLine());
            int arrivalTime = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            if (examsTime >= arrivalTime)
            {
                if (examsMin >= arrivalMin)
                {
                    
                }
            }
            else if (examsTime < arrivalTime)
            {
                
            }
        }
    }
}
