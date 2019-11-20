using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle( double _width, double _height )
        {
            Width = _width;
            Height = _height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
