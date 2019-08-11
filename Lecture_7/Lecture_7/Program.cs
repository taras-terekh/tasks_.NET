using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape triangle = new Triangle(4, 3);
            Shape isoscelesTriangle = new IsoscelesTriangle(4, 3);
            Shape circle = new Circle(4);
            Shape rectangle = new Rectangle(3, 4);
            Shape square = new Square(3, 4);

            triangle.GetName();
            triangle.GetАrea();
            isoscelesTriangle.GetName();
            isoscelesTriangle.GetАrea();
            circle.GetName();
            circle.GetАrea();
            rectangle.GetName();
            rectangle.GetАrea();
            square.GetName();
            square.GetАrea();
        }
    }
}
