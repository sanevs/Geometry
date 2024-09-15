using System;

namespace ShapesApp
{
    public class Circle : IShape
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int CalcSquare() => (int)(Math.PI * Math.Pow(Radius, 2));
    }
}
