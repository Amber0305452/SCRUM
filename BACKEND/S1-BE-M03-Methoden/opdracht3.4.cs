using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ik heb de wisselkoers van de volgende site afgehaald: https://www.wisselkoers.nl/calculator*/
namespace opdracht3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een geldbedrag in euro's in.");
            Double BedragEuro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dit bedrag is in Amerika " + (BedragEuro * 1.1267) + " waard.");
            Console.WriteLine("Dit bedrag is in Canada " + (BedragEuro * 1.4870) + " waard.");
            Console.WriteLine("Dit bedrag is in Fiji " + (BedragEuro * 2.3885) + " waard.");
            Console.WriteLine("Dit bedrag is in Hongarije  " + (BedragEuro * 321.841) + " waard.");
            Console.WriteLine("Dit bedrag is in Vietnam " + (BedragEuro * 26.243) + " waard.");
            Console.ReadKey(); 
        }
    }
}
