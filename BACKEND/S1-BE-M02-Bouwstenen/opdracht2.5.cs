using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw naam in.");
            string Name = Console.ReadLine();
            Console.WriteLine("Voer de standaardprijs in van de auto");
            int Standard = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int Automatic = 1000;
            int Leather = Standard / 100 * 5;
            int Metallic = Standard / 100 * 5; 

            int All = Automatic + Leather + Metallic;
            int Btw = (All / 100) * 21;
            int Total = All + Btw; 
            Console.WriteLine("De totale kosten zijn: " + Total + " euro.");
            Console.WriteLine(All + " euro, is het bedrag zonder de 21% btw");
            Console.WriteLine(Leather + " euro aan  leren bekleding.");
            Console.WriteLine(Metallic + " euro aan Metallic lak.");
            Console.WriteLine(Automatic + " euro aan automaat ipv handschakeling.");      
                           
            Console.ReadKey();

           
        }
    }
}
