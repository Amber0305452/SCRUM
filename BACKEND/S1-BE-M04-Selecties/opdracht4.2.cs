using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer het eerste getal in.");
            int Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer het tweede getal in.");
            int Getal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer het derde getal in");
            int Getal3 = Convert.ToInt32(Console.ReadLine());
            if(Getal3<Getal1 && Getal3 < Getal2)
            {
                Console.WriteLine("Het derde getal is het kleinst van alledrie.");
            }
            else
            {
                Console.WriteLine("Het derde getal is niet het kleinst van alledrie.");
            }
            Console.ReadKey();
        }
    }
}
