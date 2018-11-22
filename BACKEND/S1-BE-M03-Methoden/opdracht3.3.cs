using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer de hoogte van de kubus in.");
            Double Hoogte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer de lengte van de kubus in.");
            Double Lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer de breedte van de kubus in.");
            Double Breedte = Convert.ToDouble(Console.ReadLine());
            Double Inhoud = Lengte * Breedte * Hoogte;
            Console.WriteLine("De inhoud van de kubus is: " + Inhoud+ "m^3");
            Console.ReadKey();
       }
    }
}
