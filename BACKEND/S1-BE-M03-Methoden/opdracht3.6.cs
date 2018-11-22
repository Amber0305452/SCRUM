using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer je studentnummer in.");
            int Studentnummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer je voor en achternaam in.");
            String Naam = Console.ReadLine();
            Console.WriteLine("Voer je eerste cijfer in voor NED.");
            Double NED1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor NED.");
            Double NED2 = Convert.ToDouble(Console.ReadLine());
            Double NEDGemiddelde = (NED1 + NED2) / 2;
            Console.WriteLine("Voer je eerste cijfer in voor ENG.");
            Double ENG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor ENG.");
            Double ENG2 = Convert.ToDouble(Console.ReadLine());
            Double ENGGemiddelde = (ENG1 + ENG2) / 2;
            Console.WriteLine("Voer je eerste cijfer in voor WIS.");
            Double WIS1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor WIS.");
            Double WIS2 = Convert.ToDouble(Console.ReadLine());
            Double WISGemiddelde = (WIS1 + WIS2) / 2;
            Console.WriteLine("Voer je eerste cijfer in voor PRG.");
            Double PRG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor PRG.");
            Double PRG2 = Convert.ToDouble(Console.ReadLine());
            Double PRGGemiddelde = (PRG1 + PRG2 + PRG2) / 3;
            Console.WriteLine("Voer je eerste cijfer in voor DBD.");
            Double DBD1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor DBD.");
            Double DBD2 = Convert.ToDouble(Console.ReadLine());
            Double DBDGemiddelde = (DBD1 + DBD2 + DBD2) / 3;
            Console.WriteLine("Voer je eerste cijfer in voor ALG.");
            Double ALG1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Voer je tweede cijfer in voor ALG.");
            Double ALG2 = Convert.ToDouble(Console.ReadLine());
            Double ALGGemiddelde = (ALG1 + ALG2 + ALG2) / 3;
            Console.WriteLine();
            Console.WriteLine("Hallo " + Naam + ", Je hebt de volgende cijfers behaald:");
            Console.WriteLine("Voor het vak NED heb je de volgende 2 cijfers gehaald" + NED1 + " en " + NED2 + ". Dit geeft een gemiddelde van " + NEDGemiddelde);
            Console.WriteLine("Voor het vak ENG heb je de volgende 2 cijfers gehaald" + ENG1 + " en " + ENG2 + ". Dit geeft een gemiddelde van " + ENGGemiddelde);
            Console.WriteLine("Voor het vak WIS heb je de volgende 2 cijfers gehaald" + WIS1 + " en " + WIS2 + ". Dit geeft een gemiddelde van " + WISGemiddelde);
            Console.WriteLine("Voor het vak PRG heb je de volgende 2 cijfers gehaald" + PRG1 + " en " + PRG2 + ". Dit geeft een gemiddelde van " + PRGGemiddelde);
            Console.WriteLine("Voor het vak DBD heb je de volgende 2 cijfers gehaald" + DBD1 + " en " + DBD2 + ". Dit geeft een gemiddelde van " + DBDGemiddelde);
            Console.WriteLine("Voor het vak ALG heb je de volgende 2 cijfers gehaald" + ALG1 + " en " + ALG2 + ". Dit geeft een gemiddelde van " + ALGGemiddelde);
            Console.ReadKey();
        }
    }
}
