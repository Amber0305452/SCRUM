using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opdracht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int[] array = new int[10];
            int[] array2 = new int[10];
            for(int index=0; index<10; index++)
            {
                array[index] = number.Next(10, 99);                
                array2[index] = number.Next(10, 99);                
            }
            string eersteArray = string.Join("   ", array);
            Console.WriteLine("Array 1: " + eersteArray);                    
            string tweedeArray = string.Join("   ", array2);
            Console.WriteLine("Array 1: " + tweedeArray);            
            Adding(array, array2);
            Console.ReadKey();

        }
        static void Adding(int [] array, int[] array2)
        {
            int [] total = new int[10]; 
            for(int index=0; index<10; index++)
            {
                total[index] = array[index] + array2[index];
            }
            
            string sum = string.Join("  ", total);
            Console.WriteLine("Som:     " + sum);
        }
    }
}
