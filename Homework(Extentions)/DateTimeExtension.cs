using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Extentions_
{
    public static class DateTimeExtension
    {
        public static DateTime Min(this DateTime time1, DateTime time2) 
        {
            if(time1 < time2)
            {
                return time1;
            }
            else 
            {
                return time2;
            }  
        }
        public static DateTime Max(this DateTime time1, DateTime time2)
        {
            if (time1 > time2)
            {
                return time1;
            }
            else
            {
                return time2;
            }
        }
        public static DateTime BeginingOfMonth(this DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            return firstDayOfMonth;
        }
        public static DateTime EndingOfMonth(this DateTime date)
        {
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            return lastDayOfMonth;
        }
        public static void EndOfMonth()
        {

        }
    }
}
