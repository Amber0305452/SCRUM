using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to enter a number.
            Console.WriteLine("Enter a number, the programm will check if it is actually a number.");
            string numberString = Console.ReadLine();
            //Calls function checking
            Checking(numberString);
            Console.ReadKey();
        }
        static void Checking(string numberString)
        {
            //creates empty variable
            int number;
            //creates a bool, which tries to parse the entered number to an int.
            bool parseSuccess = int.TryParse(numberString, out number);
            //When the parse is a succes the programm will say it's a number and otherwise it's not a number.
            if (parseSuccess)
                Console.WriteLine("This is a number!");
            else
                Console.WriteLine("This is not a number!");

        }
    }
}
