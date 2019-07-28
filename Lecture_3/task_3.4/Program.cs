using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._4
{
    class Program
    {
        static double ProductOfGeometricProgression(double firstItem, double step, double limit)
        {
            double result = 0.0, lastItem = 0.0;
            lastItem = firstItem;
            result = firstItem;
            while (lastItem > limit)
            {
                lastItem /= step;
                if (step > 1 && lastItem < limit)
                    break;
                result *= lastItem;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double amount = 1;
            double firstItem = 10;
            double step = 2;
            double limit = 1;
            amount = ProductOfGeometricProgression(firstItem, step, limit);
        }
    }
}
