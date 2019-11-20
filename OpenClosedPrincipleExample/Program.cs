using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleExample
{
    class Program
    {
        static void Main( string[] args )
        {
            Circle circle1 = new Circle(5.0);
            Rectangle rectangle1 = new Rectangle(4.0, 10.0);
            Triangle triangle1 = new Triangle(7.0,12.0);
            Console.WriteLine( "Area of the circle: " + circle1.Area().ToString() );
            Console.WriteLine( "Area of the rectangle: " + rectangle1.Area().ToString() );
            Console.WriteLine( "Area of the triangle: " + triangle1.Area().ToString() );
            Console.ReadLine();
        }

        //If we need to add new type of shape such as square, we don't need to change anything that we typed before. We just need to create a new class which is inherited from Shape class and override abstract Area method.
        public double TotalArea( List<Shape> shapes )
        {
            double area = 0.0;
            foreach ( Shape shape in shapes )
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
