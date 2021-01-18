using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBureau
{
    public class Program
    {
        public static void Main()
        {
            //за изход да се отпечатва общата стойност в евро с два знака след запетаята
            double bitcoin = double.Parse(Console.ReadLine());
            double ChineseYuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            decimal EurosValue = 1.95m;
            decimal bitcoinsValue = 1168m;//стойност в лева
            decimal totalBitcoinsValue = (decimal)(bitcoinsValue) * (decimal)(bitcoin);
            decimal FiveYuan = 1.32m; //стойност в лева
            decimal totalYuan = FiveYuan * (decimal)ChineseYuan;
            decimal totalSumInBg = (decimal)totalBitcoinsValue + totalYuan;
            decimal totalSumInEu = totalSumInBg / (decimal)EurosValue;
            decimal result = totalSumInEu - (((decimal)comission / 100m) * totalSumInEu);
            Console.WriteLine("{0:f2}", result);
        }
    }
}
