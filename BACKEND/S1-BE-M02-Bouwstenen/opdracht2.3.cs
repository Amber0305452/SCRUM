using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal");
            int Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef een tweede getal");
            int Getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine("Het antwoord met Getal1+Getal2 is: " + (Getal1+Getal2));
            Console.WriteLine("Het antwoord met Getal1-Getal2 is: " + (Getal1-Getal2));
            Console.WriteLine("Het antwoord met Getal2-Getal1 is: " + (Getal2-Getal1));
            Console.WriteLine("Het antwoord met Getal1*Getal2 is: " + (Getal1*Getal2));
            Console.WriteLine("Het antwoord met Getal1/Getal2 is: " + (Getal1/Getal2));
            Console.WriteLine("Het antwoord met Getal2/Getal1 is: " + (Getal2/Getal1));
            Console.WriteLine("Het antwoord met Getal1%Getal2 is: " + (Getal1%Getal2));
            Console.WriteLine("Het antwoord met Getal2%Getal1 is: " + (Getal2%Getal1));

            Console.ReadKey(); 

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
