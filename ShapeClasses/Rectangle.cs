using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Rectangle:Shape
    {
        private double width;
        private double length;

        public double Width
        {
            set { width = value; }
            get { return width; }
        }

        public double Length
        {
            set { length = value; }
            get { return length; }
        }

        public Rectangle()
        {
            Width = Length = 0;
            
        }

        public Rectangle(double w, double l)
        {
            Width = w;
            Length = l;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }

        public override double GetArea()
        {
            return Length * Width;
        }


    }
}
