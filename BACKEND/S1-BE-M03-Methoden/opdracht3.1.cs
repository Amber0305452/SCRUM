using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw voornaam in.");
            String Voornaam= Console.ReadLine();
            int VoornaamLength = Voornaam.Length;
            Console.WriteLine("Voeg eventuele tussenvoegsels in.");
            String Tussenvoegsel = Console.ReadLine();
            int TussenvoegselLength = Tussenvoegsel.Length;
            Console.WriteLine("Voer uw achternaam in.");
            String Achternaam = Console.ReadLine();
            int AchternaamLength = Achternaam.Length;
            int Total = VoornaamLength + TussenvoegselLength + AchternaamLength; 
            Console.WriteLine("De totale lengte van jouw naam is: " + Total);
            Console.ReadKey();

        }
    }
}
