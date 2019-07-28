using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2
{
    /// <summary>
    /// среднее арифметическое значений в диапазоне n – m включительно
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            int arrayLength = 7;
            int[] array = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                sum += array[i];
            }
            avg = sum / arrayLength;
        }
    }
}
