﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle :Shape
    {
        private double height;
        private double width;

        public Rectangle(double h , double w)
        {
            this.height = h;
            this.width = w;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
