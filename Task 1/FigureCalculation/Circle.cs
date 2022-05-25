using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculation
{
    public class Circle : Figure
    {
        public Double Radius { get; set; } = Double.NaN;
        public Circle() : this(1) { }
        public Circle(Double radius) 
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
            throw new NotImplementedException();
        }
    }
}
