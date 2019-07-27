using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._5
{
    /// <summary>
    /// Найти расстояние между первым и последним вхождением максимального значения в массиве.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 4, 54, 93, 2, 43, 85, 71, 93, 21, 33};
            int searchNumber = -999999;
            int indexSearchFirstNumber = -1;
            int indexSearchSecondNumber = -1;
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
                if (array[i] > searchNumber)
                {
                    indexSearchFirstNumber = i;
                    searchNumber = array[i];
                    continue;
                }
                else if (array[i] == searchNumber)
                {
                    indexSearchSecondNumber = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("indexSearchFirstNumber: {0} indexSearchSecondNumber: {1}", indexSearchFirstNumber, indexSearchSecondNumber);
            Console.WriteLine("difference of two indexes = {0}", indexSearchSecondNumber - indexSearchFirstNumber);
        }
    }
}
