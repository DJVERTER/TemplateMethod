using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Square
{
    internal class RectangleSquare : ShapeSquare
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public RectangleSquare(double a, double b)
        {
            SideA = a;
            SideB = b;
        }
        protected override void CalculateShape()
        {
            Square = SideA * SideB;
        }

        protected override void Validate()
        {
            IsValid = SideA >= 0 && SideB >= 0;
        }
    }
}
