using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._2
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wat is je lengte?(cm)");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je gewicht?(kg)");
            double userWeight = Convert.ToDouble(Console.ReadLine());

            userHeight = userHeight / 100;
            double Bmi = userWeight / (userHeight * userHeight);

            Console.WriteLine();
            Console.WriteLine("Je gewicht is: " + userWeight);
            Console.WriteLine("Je lengte is: " + userHeight);
            Console.WriteLine("Je bmi is: " + Bmi);

            Console.ReadKey(); 
        }
    }


}
