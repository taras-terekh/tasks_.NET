using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstItem = 3;
            double step = 4;
            double numberOfLastItem = 3;
            ArithmeticProgression data = new ArithmeticProgression(firstItem, step, numberOfLastItem);
            data.GetSum();
            data.GetAverage();
        }
    }
}
