using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetАrea()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }

        public override void GetName()
        {
            Console.WriteLine("This is Circle with area = " + GetАrea());
        }
    }
}
