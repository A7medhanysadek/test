using System;
using System.Diagnostics;

namespace Delegates
{
    class main_class
    {
        public delegate int MathOperation(int num1, int num2);
        static void Main(string[] args)
        {
            MathOperation operations;
            operations = addition;
            operations += subtraction;
            operations += multiplication;
            operations += division;
            int num1, num2;
            Console.Write("could you please enter the first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("could you please enter the second number:");
            num2 = int.Parse(Console.ReadLine());
            operations.Invoke(num1, num2);
        }
        static int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static int subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        static int division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}