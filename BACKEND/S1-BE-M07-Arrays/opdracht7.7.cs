using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {                             
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Sum(numbers);
            Console.ReadKey();
        }
        static void Sum(int[] numbers)
        {
            int total = 0;
            for(int i=0; i<10; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine("De totale som van de 10 ingevoerde getallen is: " + total);
        }
    }
}
