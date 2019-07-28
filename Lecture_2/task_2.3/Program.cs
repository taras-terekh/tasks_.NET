using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._3
{
    /// <summary>
    /// определения суммы четных чисел в диапазоне целых значений n1 – n2
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            int count = 0;
            int arrayLength = 7;
            int n1 = 4;
            int n2 = 92;
            int[] array = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(n1, n2);
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            avg = sum / count;
        }
    }
}
