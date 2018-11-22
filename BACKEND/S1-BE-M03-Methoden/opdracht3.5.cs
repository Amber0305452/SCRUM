using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._5
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Voer de breedte van de camper in.");
            Double Breedte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer de lengte van de camper in.");
            Double Lengte = Convert.ToDouble(Console.ReadLine());
            Double Oppervlakte = Lengte * Breedte;
            Double Prijs= Oppervlakte*1.50*12;
            Double KortingDrie = (Prijs / 100) * 10;
            Double KortingTwee = (Prijs / 100) * 5;
            Double PrijsDrie = Prijs - KortingDrie;
            Double PrijsTwee = Prijs - KortingTwee;
            Console.WriteLine("U gaf aan dat de breedte van uw camper " + Breedte + " is en de lengte " + Lengte + ". Dit geeft een oppervlakte van " + Oppervlakte + ".");
            Console.WriteLine("De kosten voor 1 jaar stalling zijn: " + Prijs + " euro.");
            Console.WriteLine("De kosten voor 2 jaar stalling zijn: " + PrijsTwee + " euro.");
            Console.WriteLine("De kosten voor 3 jaar stalling zijn: " + PrijsDrie + " euro.");
            Console.ReadKey();
        }
    }
}
