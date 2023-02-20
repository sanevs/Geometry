using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    public class Triangle : IShape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c) 
        {
            A = a; B = b; C = c;
        }
        public int calcSquare()
        {
            int p = (A + B + C) / 2;
            return (int)Math.Sqrt(p*(p - A)*(p - B)*(p - C));
        }
        public bool isRectangular()
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
