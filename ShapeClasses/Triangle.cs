using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Triangle:Shape
    {
        private double tribase;
        private double triheight;

        public double Tribase
        {
            set { tribase = value; }
            get { return tribase; }
        }

        public double Triheight
        {
            set { triheight = value; }
            get { return triheight; }
        }

        public Triangle()
        {
            Tribase = Triheight = 0;
        }

        public Triangle(double tbase, double theight)
        {
            Tribase = tbase;
            Triheight = theight;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a triangle.");
        }

        public override double GetArea()
        {
            return Tribase * Triheight / 2;
        }
    }
}
