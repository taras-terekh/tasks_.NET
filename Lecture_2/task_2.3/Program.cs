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
            Console.Write("Enter array length: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the left border of the array elements: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the right border of the array elements: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            Random rand = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(n1, n2);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            avg = sum / count;
            Console.WriteLine();
            Console.WriteLine("Sum= {0} avg= {1}", sum, avg);
        }
    }
}
