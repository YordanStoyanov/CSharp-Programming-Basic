using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving
{
    public class Saving
    {
        public static void Main()
        {
            //input месечна заплата 
            //input брой месеци
            //input сума за месеца за лични разходи
            //const 30 % от месечната заплата за непредвидени разходи
            //спестени пари за месеците в %
            decimal monthlySalary = decimal.Parse(Console.ReadLine()); //месечна заплата
            decimal numberOfMonths = decimal.Parse(Console.ReadLine());//брои месеци
            decimal monthlyPersonalExpenses = decimal.Parse(Console.ReadLine());//сума за лични разходи
            decimal constMonthlyNexpectedCosts = monthlySalary * (30/100m);//постоянна сума за непредвидени разходи
            decimal savingMoney = (monthlySalary - constMonthlyNexpectedCosts - monthlyPersonalExpenses) * numberOfMonths;
            decimal totalSavingMoneyInПercent = (savingMoney / (monthlySalary * numberOfMonths)) * 100;
            Console.WriteLine("She can save {0:f2}%", totalSavingMoneyInПercent);
            Console.WriteLine("{0:f2}", savingMoney);

        }
    }
}
