using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hier wordt de datum van vandaag bepaald*/ 
            DateTime Now = DateTime.Now; 
            /*Vraagt de gebruiker om naam en geboortedatum,
             * waarna de geboortedatum om wordt gezet naar een datum.
             * De uiteindelijke leeftijd is het jaar van nu min het geboortejaar*/ 
            Console.WriteLine("Voer u voornaam in.");
            string Name = Console.ReadLine();
            Console.WriteLine("Voer u geboortedatum in.(dd/mm/yyyy)");
            DateTime Birthday = Convert.ToDateTime(Console.ReadLine());
            int Age = Now.Year - Birthday.Year;
            Console.WriteLine(Name + " is " + Age + " jaar oud.");
            Console.ReadKey();              
        }
    }
}
