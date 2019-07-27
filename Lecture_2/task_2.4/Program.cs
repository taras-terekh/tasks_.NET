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
            Console.Write("Enter array length: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            int[] reverseArray = new int[arrayLength];
            Random rand = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write("{0} ", array[i]);
                reverseArray[i] = array[i];
            }
            Console.WriteLine();
            Console.WriteLine("reverse Array:");
            for (int i = reverseArray.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", reverseArray[i]);
            }
            Console.WriteLine();
        }
    }
}
