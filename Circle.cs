using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double circle;

        public Circle(double c)
        {
            this.circle = c;
        }

        public override double CalculateArea()
        {
         return Math.PI * Math.Pow(circle, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * circle;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
