using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw voornaam in");
            String Voornaam = Console.ReadLine();
            int VoornaamLength = Voornaam.Length;
            char Eerste = Voornaam[0];
            char Lower = char.ToLower(Eerste);
            Console.WriteLine("Voeg een eventueel tussenvoegsel in.");
            String Tussenvoegsel = Console.ReadLine();
            int TussenvoegselLength = Tussenvoegsel.Length;
            Console.WriteLine("Voer uw achternaam in.");
            String Achternaam = Console.ReadLine();
            //Creeërt een nieuwe string waarin achternaam compleet naar kleine letters word gezet
            String updatedAchternaam = Achternaam.Substring(0).ToLower();
            int AchternaamLength = Achternaam.Length;
            int TotalLength = VoornaamLength + TussenvoegselLength + AchternaamLength;
            Console.WriteLine(Lower + updatedAchternaam + TotalLength);
            Console.ReadKey();
            
        }
    }
}
