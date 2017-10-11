using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Circle:Shape
    {
        private double radius;

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double rad)
        {
            Radius = rad;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }

        public override double GetArea()
        {
            //return Math.PI * Math.Pow(Radius, 2); 
            return Radius * Radius * Math.PI;
        }

    }
}
