using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public Triangle( double _height, double _base )
        {
            Height = _height;
            Base = _base;
        }
        public override double Area()
        {
            return (Height * Base) / 2;
        }
    }
}
