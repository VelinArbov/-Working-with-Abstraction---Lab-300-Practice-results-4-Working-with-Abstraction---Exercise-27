using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 12);
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            Console.WriteLine(rectangle.CalculateArea());
            rectangle.CalculatePerimeter();
            rectangle.CalculatePerimeter();
            Console.WriteLine(rectangle.CalculatePerimeter());
            ;
        }
    }
}
