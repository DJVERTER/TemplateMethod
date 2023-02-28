using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Square
{
    public class CircleSquare : ShapeSquare
    {
        public double Radius { get; init; }
        public CircleSquare(double r)
        {
            Radius = r;
        }

        protected override void Validate()
        {
            IsValid = Radius >= 0;
        }

        protected override void CalculateShape()
        {
            Square = Math.PI * Radius * Radius;
        }
    }
}
