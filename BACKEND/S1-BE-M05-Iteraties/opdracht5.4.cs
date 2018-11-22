using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Nu = DateTime.Now;
            int Year = Nu.Year; 
            //Gaat loop in van 1900 tot nu, en hoogt het jaar steeds op tot die niet meer aan de voorwaarde voldoet.
            for(int startYear= 1900; startYear<=Year; startYear++)
            {
                //Als de datum een schrikkeljaar is gaat hij de lus in en print dat het idd een schrikkeljaar is.
                if (DateTime.IsLeapYear(startYear))
                {
                    Console.WriteLine("{0} is a leap year.", startYear);    
                }
                else
                {
                    //Als die niet aan de if voldoet schrijft het programma dat het niet een schrikkeljaar is.
                    Console.WriteLine("{0} is not a leap year.", startYear);
                }
            }
            Console.ReadKey();
        }
    }
}
