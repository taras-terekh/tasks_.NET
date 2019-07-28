using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3
{
    class Program
    {
        enum Operation
        {
            Ascending = 1,
            Descending
        }

        static void SortMethod(Operation op)
        {
            int arrayLength = 7;
            int[] array = new int[arrayLength];
            int swap;
            bool exit = false;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            while (!exit)
            {
                exit = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    switch (op)
                    {
                        case Operation.Ascending:
                            if (array[i] > array[i + 1])
                            {
                                swap = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = swap;
                                exit = false;
                            }
                            break;
                        case Operation.Descending:
                            if (array[i] < array[i + 1])
                            {
                                swap = array[i];
                                array[i] = array[i + 1];
                                array[i + 1] = swap;
                                exit = false;
                            }
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int sortSelection = 1;
            switch (sortSelection)
            {
                case 1:
                    SortMethod(Operation.Ascending);
                    break;
                case 2:
                    SortMethod(Operation.Descending);
                    break;
            }
        }
    }
}
