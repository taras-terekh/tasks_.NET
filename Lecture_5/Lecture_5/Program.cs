using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomArrayLib;

namespace Lecture_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftBorder = 4;
            int rightBorder = 9;
            CustomArray<int> data = new CustomArray<int>(leftBorder, rightBorder);
            Random rand = new Random();
            for (int i = leftBorder; i <= rightBorder; i++)
            {
                data[i] = rand.Next(0, 100);
            }
        }
    }
}
