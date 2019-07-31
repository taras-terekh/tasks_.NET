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
            Console.Write("enter the number of rows  of the first matrix: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number of columns of the first matrix: ");
            int columns1 = Convert.ToInt32(Console.ReadLine());
            //int[,] matrix1 = new int [rows1, columns1];
            Matrix matrix1 = new Matrix(rows1,columns1);
            Console.WriteLine("\nMatrix 1:");
            Random rand = new Random();
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    matrix1[i,j] = rand.Next(0, 99);
                    Console.Write("{0:D2} ", matrix1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("enter the number of rows  of the second matrix: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number of columns of the second matrix: ");
            int columns2 = Convert.ToInt32(Console.ReadLine());
            Matrix matrix2 = new Matrix(rows2, columns2);
            Console.WriteLine("\nMatrix 2:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    matrix2[i, j] = rand.Next(0, 99);
                    Console.Write("{0:D2} ", matrix2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("select action: Addition=1 Subtraction=2 Multiplication=3 \n");
            Console.WriteLine("Rezult: ");
            int select = Convert.ToInt32(Console.ReadLine());
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
