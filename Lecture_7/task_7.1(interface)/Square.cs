using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1_interface_
{
    class Square : Rectangle, IShape
    {
        public Square(double width, double height) : base(width, height)
        { }

        public override double GetАrea()
        {
            return Width * Height;
        }

        public override void GetName()
        {
            Console.WriteLine("This is Square with area = " + GetАrea());
        }
    }
}
