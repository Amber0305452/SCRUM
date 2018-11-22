using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();

            int sum = 0;
            //Met behulp van een forloop wordt er 5x gegooid.
            for (int index = 1; index < 6; index++)
            {
                var roll = number.Next(1, 7);
                Console.WriteLine("Met dobbelsteen " + index + ", heb je " + roll + " gegooid.");
                sum += roll;
            }
            int average = sum / 5;
            Console.WriteLine("De totale som van de 5 dobbelstenen is: " + sum + ". Het gemiddelde van de 5 worpen is: " + average);
            Console.ReadKey();
        }
    }
}
