using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maakt verschillende variabelen aan.
            Console.WriteLine("Voer een getal in tussen 10 en 1.000.000.");
            int Getal = Convert.ToInt32(Console.ReadLine());
            int Copy=0;
            int Copy1 = 0; 
            int Disarium=0;                      
            
             // Het programma gaat een forloop in om een disariumgetal constant te laten bepalen.
             for(int index=0;index<=Getal ; index++)
            {
                //Zet Copy naar de index, zodat op de manier alle getallen onder het ingevoerde getal worden langs gegaan.
                Copy = index;
                Copy1 = index; 
                String stringGetal = Convert.ToString(Copy);
                int GetalLength = stringGetal.Length;
                int Sum = 0; 
                while (Copy>0)
                {  
                    //Bepaald of het een disariumgetal is.
                    Disarium = Copy % 10;
                    /*
                     * Math.Pow berekent exponentiële waarden. 
                     * Het heeft de machten van getallen nodig, zoals het kwadrateren van waarden. 
                     * Het is een eenvoudige en handige manier om exponenten in de C # -taal te berekenen.
                     */
                    Sum = Sum + (int)Math.Pow(Disarium, GetalLength);
                    GetalLength--;
                    Copy = Copy / 10;
                     
                }
                //Is het disarium getal gelijk aan het originele getal, wat de copy1 is dan moet het programma het disariumgetal weergeven.
                if (Sum == Copy1)
                {
                    Console.WriteLine(Sum);
                }
             }

            Console.ReadKey();
        }
    }
}
