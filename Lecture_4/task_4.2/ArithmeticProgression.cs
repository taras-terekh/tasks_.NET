using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._2
{
    class ArithmeticProgression
    {
        public double firstItem;
        public double step;
        public double numberOfLastItem;

        public ArithmeticProgression (double firstItem, double step, double numberOfLastItem)
        {
            this.firstItem = firstItem;
            this.step = step;
            this.numberOfLastItem = numberOfLastItem;
        }

        public double Sum()
        {
            double sumN = 0.0, lastItem = 0.0;
            if (lastItem == firstItem)
                return lastItem;
            lastItem = firstItem;
            sumN = firstItem;
            for (int i = 1; i < numberOfLastItem; i++)
            {
                lastItem = firstItem + i * step;
                sumN += lastItem;
            }
            return sumN;
        }

        public double GetSum()
        {
            double sumN;
            sumN = Sum();
            return sumN;
        }

        private double Average ()
        {
            double averageN = 0;
            averageN = Sum() / numberOfLastItem;
            return averageN;
        }

        public double GetAverage()
        {
            double averageN;
            averageN = Average();
            return averageN;
        }
    }
}
