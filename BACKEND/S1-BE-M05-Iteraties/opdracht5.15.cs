using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voeg een tekst in, het programma zal kijken of het een palindroom is.");
            String Tekst = Console.ReadLine();
            //Verwijderd de spaties
            Tekst = Tekst.Replace(" ", String.Empty);
            //Bepaald de lengte van de ingevoerde tekst
            int TekstLength = Tekst.Length; 
            //Maakt van de string een char en draait deze om 
            char[] temp = Tekst.ToCharArray();
            Array.Reverse(temp);
            String Tekst2 = new string(temp);
            //Gaat een if lus in die ervoor zorgt dat de lengte niet groter is dan 25
            if (TekstLength <= 25)
            {
                //Als de gewone tekst en de omgedraaide gelijk zijn zegt die dat het een palindroom is
                if (Tekst.ToLower().Equals(Tekst2.ToLower()))
                {
                    Console.WriteLine("De tekst die je hebt ingevoerd is een palindroom.");
                   
                }
                else
                {
                    //Anders laat die zien dat het geen palindroom.
                    Console.WriteLine("De tekst die je hebt ingevoerd is geen palindroom.");
                    
                }
            }
            else
            {
                Console.WriteLine("De tekst mag niet meer dan 25 tekens hebben.");
            }
            Console.ReadKey();
        
        }
    }
}
