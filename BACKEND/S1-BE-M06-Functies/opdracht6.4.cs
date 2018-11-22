using System;

namespace opdracht6._4
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("Enter the first number.");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(firstNumber + "+" + secondNumber + "=" + Adding(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + "-" + secondNumber + "=" + Minus(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + "/" + secondNumber + "=" + Divide(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + "*" + secondNumber + "=" + Multipli(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + "%" + secondNumber + "=" + Modulo(firstNumber, secondNumber));
            Console.ReadKey();
        }
        static double Adding(double firstNumber, double secondNumber)
        {
            double addition = firstNumber + secondNumber;
            return addition; 
        }
        static double Minus(double firstNumber, double secondNumber)
        {
            double minus = firstNumber - secondNumber;
            return minus;
        }
        static double Divide(double firstNumber, double secondNumber)
        {
            double divide = firstNumber / secondNumber;
            return divide;
        }
        static double Multipli(double firstNumber, double secondNumber)
        {
            double multipli = firstNumber * secondNumber;
            return multipli;
        }
        static double Modulo(double firstNumber, double secondNumber)
        {
            double modulo = firstNumber % secondNumber;
            return modulo;
        }
    }
}
