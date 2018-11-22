using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace opdracht3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            String Month = DateTime.Now.Month.ToString();            
            String Year = DateTime.Now.Year.ToString();
            DayOfWeek DayName = DateTime.Now.DayOfWeek;
            String Day = DateTime.Now.Day.ToString();
            int dayOfYear = DateTime.Now.DayOfYear;
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;            
            Calendar cal = dfi.Calendar;           


            Console.WriteLine("Today it is: " + Now);
            Console.WriteLine("The current year is: " + Year);
            Console.WriteLine("The current month is: " + Now.ToString("MMMMMMMMMM")+". This is the "+Month+"th month.");
            Console.WriteLine("The current day is: " + DayName);
            Console.WriteLine("It is the " + Day + "th day of the month.");
            Console.WriteLine("It is the " + dayOfYear + "th day of the year.");
            Console.WriteLine("It is week number: {1} ", Now,
                              cal.GetWeekOfYear(Now, dfi.CalendarWeekRule,
                                                dfi.FirstDayOfWeek));                             
            Console.ReadKey();
        }
    }
}
