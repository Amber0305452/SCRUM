using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics; 

namespace opdracht3._10.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new stopwatch
            Stopwatch stopwatch = new Stopwatch();            
            //Begin timing
            stopwatch.Start();           
            Console.WriteLine("Voer uw naam in");
            String Naam = Console.ReadLine();
            Console.WriteLine("Voer uw leeftijd in");
            int Leeftijd = Convert.ToInt32(Console.ReadLine());        
            //stop timing
            stopwatch.Stop();
            Console.WriteLine("Je hebt er " + stopwatch.Elapsed + " over gedaan.");
            Console.ReadKey();


        }
    }
}
