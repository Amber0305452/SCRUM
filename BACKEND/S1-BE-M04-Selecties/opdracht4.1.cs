using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een eerste getal in.");
            int EersteGetal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer een tweede getal in.");
            int TweedeGetal = Convert.ToInt32(Console.ReadLine());
            if (EersteGetal < TweedeGetal)
            {
                Console.WriteLine("Het tweede getal is het grootste.");
            }
            else if (TweedeGetal < EersteGetal)
            {
                Console.WriteLine("Het eerste getal is het grootste.");
            }
            else 
            {
                Console.WriteLine("De getallen zijn gelijk aan elkaar.");
            }
            Console.ReadKey();
        }
    }
}
