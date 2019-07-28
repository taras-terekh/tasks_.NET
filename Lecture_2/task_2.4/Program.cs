using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._4
{
    /// <summary>
    /// Поменять местами значения первого и последнего элементов массива, второго и предпоследнего и тд.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 6;
            int[] array = new int[arrayLength];
            int[] reverseArray = new int[arrayLength];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                reverseArray[i] = array[i];
            }
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseArray[j] = array[i];
                j++;
            }
        }
    }
}
