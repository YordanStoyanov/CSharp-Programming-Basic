using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetParking1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfHours = int.Parse(Console.ReadLine());
            int numberOfHours1 = 0;
            int days = 1;
            decimal sum = 0;
            decimal totalSum = 0;
            
                while (true)
                {
                    numberOfHours1 = numberOfHours;
                    sum = 0;
                    if (days % 2 == 0)
                    {
                        while (true)
                        {
                            if (numberOfHours1 % 2 != 0)
                            {
                                sum += 2.5m;//за всеки четен ден и нечетен час
                            }
                            else if (numberOfHours1 % 2 == 0)
                            {
                                sum += 1;
                            }
                            numberOfHours1--;
                            if (numberOfHours1 == 0)
                            {
                                totalSum += sum;
                                Console.WriteLine("Day: {0} - {1:f2} leva", days, sum);
                                break;
                            }
                        }
                    }

                    if (days % 2 != 0)
                    {
                        while (true)
                        {
                            if (numberOfHours1 % 2 == 0)
                            {
                                sum += 1.25m;//за всеки нечетен ден и четен час
                            }
                            else if (numberOfHours1 % 2 != 0)
                            {
                                sum += 1;
                            }
                            numberOfHours1--;
                            if (numberOfHours1 == 0)
                            {
                                totalSum += sum;
                                Console.WriteLine("Day: {0} - {1:f2} leva", days, sum);
                                break;
                            }
                        }
                    }

                    if (numberOfDays == days)
                    {
                        break;
                    }
                    days++;
                }

            Console.WriteLine("Total: {0:f2} leva", totalSum);
        }
    }
}
