using System;
namespace summation_of_two_numbers
{
    public abstract class shape
    {
        public abstract double CalculateArea();
    }
    public class Rectangle: shape
    {
        int width;
        int length;
        public Rectangle()
        {
            Console.Write("enter the rectangle width:");
            width = int.Parse(Console.ReadLine());
            Console.Write("enter the rectangle length:");
            length = int.Parse(Console.ReadLine());
        }
        public override double CalculateArea()
        {
            return width * length;
        }
    }
    public class circle : shape 
    {
        int r;
        public circle()
        {
            Console.Write("enter circle radius:");
            r = int.Parse(Console.ReadLine());
        }
        public override double CalculateArea()
        {
            return System.Math.PI * System.Math.Pow(r,2);
        }
    }
    class main_class
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine($"rectangle area is : {r.CalculateArea()}");
            circle c = new circle();
            Console.WriteLine($"circle area is : {c.CalculateArea()}");
        }
    }
}