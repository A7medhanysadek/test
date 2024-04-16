using System;
namespace calculateRectangleAreaAndPerimeter;

public class Rectangle
{
    public int length
    { set; get; }
    public int width
    { set; get;}
    public int calculateArea()
    {
        return length * width;
    }
    public int calculatePerimeter()
    {
        return (width+length) * 2;
    }
}
class main_class
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        Console.Write("enter the length:");
        r.length = int.Parse(Console.ReadLine());
        Console.Write("enter the width:");
        r.width = int.Parse(Console.ReadLine());
        Console.WriteLine($"the rectangle area is : {r.calculateArea()}");
        Console.WriteLine($"the rectangle Perimeter is : {r.calculatePerimeter()}");
    }
}