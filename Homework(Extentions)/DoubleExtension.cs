using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extentions_
{
    public static class DoubleExtension
    {
        public static string ToPercent(this double num)
        {
            return string.Format("{0:0.00}%", num * 100);
        }
        public static double RoundDown(this double num)
        {
            double rounded = Math.Floor(num);
            return rounded;
        }
        public static decimal ToDecimal(this double num)
        {
            var decimalNum = Convert.ToDecimal(num);
            return decimalNum;
        }
        public static bool IsGreater(this double num)
        {
            int num1 = Convert.ToInt32(num);
            if(num > num1)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
        public static bool IsLess(this double num)
        {
            int num1 = Convert.ToInt32(num);
            if (num < num1)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
    }
}
