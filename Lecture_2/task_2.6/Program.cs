using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._6
{
    /// <summary>
    /// Записать в массив-матрицу произвольного размера значение нуль в элементы по левую сторону главной диагонали, единицу – по правую.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[arrayLength, arrayLength];
            Console.WriteLine("Array:");
            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write("{0} ", array[i, j]);
                    if (i < j)
                        array[i, j] = 1;
                    else if(i > j)
                        array[i, j] = 0;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("New array:");
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
