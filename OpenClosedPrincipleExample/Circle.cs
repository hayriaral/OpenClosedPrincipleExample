using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle( double _radius )
        {
            Radius = _radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
