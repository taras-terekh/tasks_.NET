using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double lengthBase, double height) : base(lengthBase, height)
        { }


        public override double GetАrea()
        {
            return 0.5 * LengthBase * Height;
        }

        public override void GetName()
        {
            Console.WriteLine("This is Isosceles Triangle with area = " + GetАrea());
        }
    }
}
