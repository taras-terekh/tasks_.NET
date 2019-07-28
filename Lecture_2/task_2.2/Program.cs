using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._2
{
    /// <summary>
    /// определения суммы четных чисел в диапазоне целых значений 0 – n1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            int count = 0;
            int arrayLength = 7;
            int n1 = 65;
            int[] array = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, n1);
                while (array[i] % 2 == 0)
                {
                    sum += array[i];
                    count++;
                    break;
                }
            }
            avg = sum / count;
        }
    }
}
