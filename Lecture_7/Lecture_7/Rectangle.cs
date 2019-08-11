using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_7
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetАrea()
        {
            return Width * Height;
        }

        public override void GetName()
        {
            Console.WriteLine("This is Rectangle with area = " + GetАrea());
        }
    }
}
