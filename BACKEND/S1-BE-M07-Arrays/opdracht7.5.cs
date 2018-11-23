using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you BSN-number.");
            int bsnNumber = Convert.ToInt32(Console.ReadLine());
            int[] digits = bsnNumber.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            Elfproef(digits);
           
            Console.ReadKey();
        }

         static void Elfproef(int[]digits)
        {
            int sum = 0;
            int variable = 9; 
            for(int index =0; index< digits.Length; index++)
            {
                int getal = digits[index] * variable;
                variable = variable - 1;
                if (digits[index] == 9)
                {
                    getal = digits[index] * (-1);
                    Console.WriteLine(digits[index] + "* -1 = " + getal);
                }
                sum = sum + getal;
            }
            Console.WriteLine("So we can check if it is indeed right or wrong we display the sum here: "+sum);

           
            if (sum % 11 == 0)
            {
                Console.WriteLine("This is a right BSN number");
            }
            else
            {
                Console.WriteLine("This is a wrong BSN number");
            }
            
            
        }
     
       
    }
}
