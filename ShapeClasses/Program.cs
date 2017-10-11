using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Drawing = new List<Shape>();

            Drawing.Add(new Circle(3));
            Drawing.Add(new Circle(4));

            Drawing.Add(new Triangle(3, 4));
            Drawing.Add(new Triangle(5, 7));

            Drawing.Add(new Rectangle(2, 5));
            Drawing.Add(new Rectangle(4, 10));

            //calculate the area of the whole drawing
            //sum 
            double sum = 0;

            //for (int i = 0; i < Drawing.Count; i++)
            //{
            //    sum += Drawing[i].GetArea(); //adds the area of each element (shape)
            //}

            foreach (Shape Element in Drawing)
            {
                sum = sum + Element.GetArea();
            }

            Console.WriteLine(sum);

        }
    }
}
