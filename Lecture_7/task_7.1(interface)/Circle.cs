using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1_interface_
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetАrea()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }

        public void GetName()
        {
            Console.WriteLine("This is Circle with area = " + GetАrea());
        }
    }
}
