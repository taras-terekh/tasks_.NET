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
            Console.Write("Enter array length: ");
            double sum = 0, avg = 0;
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            Console.WriteLine("Array:");
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write("{0} ", array[i]);
                sum += array[i];
            }

            avg = sum / arrayLength;
            Console.WriteLine();
            Console.WriteLine("Sum= {0} avg= {1}", sum, avg);
        }
    }
}
