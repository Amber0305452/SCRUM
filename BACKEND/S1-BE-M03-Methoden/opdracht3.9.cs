using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een datum in(dd/mm/yyyy).");
            DateTime Vandaag = Convert.ToDateTime(Console.ReadLine());
            //Berekend het aantal dagen in de ingegeven datum.
            int Days = DateTime.DaysInMonth(DateTime.Vandaag.Year, DateTime.Vandaag.Month);
            Console.WriteLine("In deze maand zitten " + Days + " dagen.");
            Console.ReadKey();
        }
    }
}
