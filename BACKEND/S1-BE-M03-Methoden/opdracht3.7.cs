using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een tekst in, het maakt niet uit welke.");
            String Woord = Console.ReadLine();
            //Hij maakt hieronder een nieuwe string aan waarin hij het ingevoerde woord langsgaat en alle klinkers vervangt met een *
            String Klinkerloos= Woord.Replace("a", "*").Replace("e", "*").Replace("i", "*").Replace("o", "*").Replace("u", "*").Replace("A", "*").Replace("E", "*").Replace("I", "*").Replace("O", "*").Replace("U", "*");
            Console.WriteLine(Klinkerloos);
            Console.ReadKey();
        }
    }
}
