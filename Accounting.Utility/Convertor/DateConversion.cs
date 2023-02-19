using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
    public static class DateConversion
    {
        public static string ToSolarDate(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date) + "/" + pc.GetMonth(date).ToString("00") + "/" + pc.GetDayOfMonth(date).ToString("00");
        }

        public static DateTime ToInternationalDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, new System.Globalization.PersianCalendar());
        }
    }
}
