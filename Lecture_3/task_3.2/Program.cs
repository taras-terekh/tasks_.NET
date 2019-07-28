using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._2
{
    class Program
    {
        enum Operation
        {
            Ascending = 1,
            Descending
        }

        static void SortMethod(int[] array, Operation op)
        {
            int swap;
            bool exit = false;
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

        static bool SortCheck(int[] array, bool sorted, int checkSortSelection)
        {
            switch (checkSortSelection)
            {
                case 1:
                    if (sorted == false)
                    {
                        for (int i = 0; i < array.Length - 1; ++i)
                        {
                            if (array[i] < array[i + 1])
                            {
                                return true;
                            }
                        }
                    }
                    else
                        return false;
                    break;
                case 2:
                    if (sorted == false)
                    {
                        for (int i = 0; i < array.Length - 1; ++i)
                        {
                            if (array[i] > array[i + 1])
                            {
                                return true;
                            }
                        }
                    }
                    else
                        return false;
                    break;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int sortSelection = 1;
            int arrayLength = 7;
            int[] array = new int[arrayLength];
            bool sorted = false;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            switch (sortSelection)
            {
                case 1:
                    SortMethod(array, Operation.Ascending);
                    break;
                case 2:
                    SortMethod(array, Operation.Descending);
                    break;
            }
            int checkSortSelection = 1;
            sorted = SortCheck(array, sorted, checkSortSelection);
        }
    }
}
