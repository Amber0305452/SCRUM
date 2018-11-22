using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int getal=100; getal<=1000; getal++)
            {
                //int antwoord = getal + 1000;
                sum = sum + getal; 
               // Console.WriteLine("De som van " + getal + "+1000=" + antwoord);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
