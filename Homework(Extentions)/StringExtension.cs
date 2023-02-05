using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extentions_
{
    public static class StringExtension
    {
        public static bool IsNumber(string num)
        {
            bool isInt;
            int number;

            isInt = Int32.TryParse(num, out number);
            if(isInt)
            {
                return true;
            }
            return false;
        }
    }
}
