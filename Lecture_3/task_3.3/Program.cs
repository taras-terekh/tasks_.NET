using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._3
{
    class Program
    {
        static double ProductOfArithmeticProgression(double firstItem, double step, int amount)
        {
            double result = 0.0, lastItem = 0.0;
            if (amount == 1)
            {
                return firstItem;
            }
            lastItem = firstItem;
            result = firstItem;
            for (int i = 2; i <= amount; i++)
            {
                lastItem += step;
                result *= lastItem;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double product = 1;
            double firstItem = 3;
            double step = 2;
            int amount = 5;
            product = ProductOfArithmeticProgression(firstItem, step, amount);
        }
    }
}
