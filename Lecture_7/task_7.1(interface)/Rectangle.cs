using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1_interface_
{
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double GetАrea()
        {
            return Width * Height;
        }

        public virtual void GetName()
        {
            Console.WriteLine("This is Rectangle with area = " + GetАrea());
        }
    }
}
