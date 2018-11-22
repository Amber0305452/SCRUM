using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a date.(dd/mm/yyyy)");
            DateTime Nu = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("If the date is invalid, the application will crash.");
            DateTime firstDay = new DateTime(Nu.Year, Nu.Month, 1);
            String dayOfFirstDay = firstDay.DayOfWeek.ToString();
            Console.WriteLine("The first day of the inserted date is: " + dayOfFirstDay);
            Console.ReadKey();
        }
    }
}
