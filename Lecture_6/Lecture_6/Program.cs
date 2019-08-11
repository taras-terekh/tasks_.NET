using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows1 = 4;
            int columns1 = 4;
            Matrix matrix1 = new Matrix(rows1, columns1);
            Random rand = new Random();
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    matrix1[i, j] = rand.Next(0, 99);
                }
            }
            matrix1.ToString();
            int rows2 = 4;
            int columns2 = 4;
            Matrix matrix2 = new Matrix(rows2, columns2);
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    matrix2[i, j] = rand.Next(0, 99);
                }
            }
            matrix2.ToString();
            Console.WriteLine();
            int select = 1;//Addition=1 Subtraction=2 Multiplication=3
            Console.WriteLine("Rezult: ");
            Matrix matrix3 = new Matrix(1, 1);
            Matrix matrix4 = new Matrix(1, 1);
            Matrix matrix5 = new Matrix(1, 1);
            switch (select)
            {
                case 1:
                    try
                    {
                        matrix3 = matrix1 + matrix2;
                        matrix3.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception: {ex.Message}");
                    }
                    break;
                case 2:
                    try
                    {
                        matrix4 = matrix1 - matrix2;
                        matrix4.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception: {ex.Message}");
                    }
                    break;
                case 3:
                    try
                    {
                        matrix5 = matrix1 * matrix2;
                        matrix5.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception: {ex.Message}");
                    }
                    break;
            }
        }
    }
}
