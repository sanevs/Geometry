using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    public class Rectangle : IShape
    {
        public int A { get; }
        public int B { get; }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public int CalcSquare()
        {
            return A * B;
        }
    }
}
