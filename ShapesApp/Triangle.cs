using System;

namespace ShapesApp
{
    public class Triangle : IShape
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public Triangle(int a, int b, int c) 
        {
            A = a; 
            B = b; 
            C = c;
        }

        public int CalcSquare()
        {
            int p = (A + B + C) / 2;
            return (int)Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            double Ain2 = Math.Pow(A, 2);
            double Bin2 = Math.Pow(B, 2);
            double Cin2 = Math.Pow(C, 2);
            return
                (Ain2 == Bin2 + Cin2) ||
                (Bin2 == Ain2 + Cin2) ||
                (Cin2 == Ain2 + Bin2);
        }
    }
}
