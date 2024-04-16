using System;
namespace summation_of_two_numbers
{
    class main_class
    {
     static void Main(string[] args)
        {
            Console.Write("enter the first number:");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("enter the second number:");
            int second_num = int.Parse(Console.ReadLine());
            Console.WriteLine("the summation result is : " + (first_num + second_num));
        }
    }
}