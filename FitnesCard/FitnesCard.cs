using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesCard
{
    public class FitnesCard
    {
        public static void Main()
        {
            decimal sum = decimal.Parse(Console.ReadLine());//сума
            string sex = Console.ReadLine();//f or m
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            if (sex == "m")
            {
                if (sport == "Gym")
                {
                    int gym = 42;
                }
                else if (sport == "Boxing")
                {
                    int boxing = 41;
                }
                else if (sport == "Yoga")
                {
                    int yoga = 45;
                }
                else if (sport == "Zumba")
                {
                    int zumba = 44;
                }
                else if (sport == "Dances")
                {
                    int dances = 51;
                }
                else if (sport == "Pilates")
                {
                    int pilates = 39;
                }
            }
            else if (sex == "f")
            {
                if (sport == "Gym")
                {
                    int gym = 35;
                }
                else if (sport == "Boxing")
                {
                    int boxing = 37;
                }
                else if (sport == "Yoga")
                {
                    int yoga = 52;
                }
                else if (sport == "Zumba")
                {
                    int zumba = 31;
                }
                else if (sport == "Dances")
                {
                    int dances = 53;
                }
                else if (sport == "Pilates")
                {
                    int pilates = 37;
                }
            }
            if (sum > sport.Length)
            {
                if (age <= 19)
                {
                    Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
                }
                else
                {
                    Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
                    //отпечатва се ако сумата е достатъчна
                }
                
            }
            else if (sum < sport.Length)
            {
            Console.WriteLine("You don't have enough money! You need ${0} more.", sport.Length - sum);//ако сумата не е достатъчна да се закупи ката,
            //където {money} e оставащата сума нужна, за да се закупи картата.
            }
        }
    }
}

/*
Пол Gym Boxing Yoga Zumba Dances Pilates
мъж $42 $41 $45 $34 $51 $39
жена $35 $37 $42 $31 $53 $37
Всички цени на карти за ученици (възраст под 19 години вкл.) са с 20% намаление.
 */