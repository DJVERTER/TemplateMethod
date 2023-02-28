using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Square
{
    public class TriangleSquare : ShapeSquare
    {
        public double TriangleSide { get; init; }
        public double TriangleHeight { get; init; }
        public TriangleSquare(double a, double h) 
        {
            TriangleSide = a;
            TriangleHeight = h;
        }
        protected override void CalculateShape()
        {
            Square = 0.5 * TriangleSide * TriangleHeight;
        }

        protected override void Validate()
        {
            IsValid = TriangleHeight >= 0 || TriangleHeight >=0;
        }
    }
}
