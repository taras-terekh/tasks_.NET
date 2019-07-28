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
            int arrayLength = 5;
            int[,] array = new int[arrayLength, arrayLength];
            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    if (i < j)
                        array[i, j] = 1;
                    else if(i > j)
                        array[i, j] = 0;
                }
            }
        }
    }
}
