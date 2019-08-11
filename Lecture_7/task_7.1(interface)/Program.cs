using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1_interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape triangle = new Triangle(4, 3);
            IShape isoscelesTriangle = new IsoscelesTriangle(5, 3);
            IShape circle = new Circle(4);
            IShape rectangle = new Rectangle(5, 4);
            IShape square = new Square(3, 4);

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
