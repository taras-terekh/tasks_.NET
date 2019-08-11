using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class Triangle : Shape
    {
        public double LengthBase { get; set; }
        public double Height { get; set; }

        public Triangle(double lengthBase, double height)
        {
            this.LengthBase = lengthBase;
            this.Height = height;
        }

        public override double GetАrea()
        {
            return 0.5 * LengthBase * Height;
        }

        public override void GetName()
        {
            Console.WriteLine("This is Triangle with area = " + GetАrea());
        }
    }
}
