using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    public class Circle : IShape
    {
        public int Radius{get;}

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int calcSquare() => 
            (int)(Math.PI * Math.Pow(Radius, 2));
    }
}
