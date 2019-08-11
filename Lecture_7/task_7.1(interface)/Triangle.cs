using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1_interface_
{
    class Triangle : IShape
    {
        public double LengthBase { get; set; }
        public double Height { get; set; }

        public Triangle(double lengthBase, double height)
        {
            this.LengthBase = lengthBase;
            this.Height = height;
        }

        public virtual double GetАrea()
        {
            return 0.5 * LengthBase * Height;
        }

        public virtual void GetName()
        {
            Console.WriteLine("This is Triangle with area = " + GetАrea());
        }
    }
}
