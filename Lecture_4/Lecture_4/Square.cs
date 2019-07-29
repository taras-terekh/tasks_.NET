using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4
{
    public class Square
    {
        public double side, perimeter, area;

        public void CalculateSquare (double side)
        {
            this.perimeter = side * 4;
            this.area = side * side;
        }
    }
}
