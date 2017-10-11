using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    abstract class Shape
    {   //all abstract methods are virtual 

        public abstract void Draw();

        public abstract double GetArea();

        public override string ToString() //overriding the object class 
        {
            return "The area of the shape is: " + GetArea();
        }


    }
}
