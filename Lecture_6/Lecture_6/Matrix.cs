using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6
{
    class Matrix
    {
        private readonly int _rows;
        private readonly int _columns;

        private int[,] _matrix;

        public Matrix (int rows, int columns)
        {
            this._rows = rows;
            this._columns = columns;
            _matrix = new int[_rows,_columns];
        }


        public int this[int index, int index1]
        {
            get => _matrix[index, index1];
            set => _matrix[index, index1] = value;
        }
        
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix rezult = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++)
                {
                    int sum = matrix1._matrix[i, j] + matrix2._matrix[i, j];
                    rezult._matrix[i, j] = sum;
                }
            }
            return rezult;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix rezult = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++)
                {
                    int sum = matrix1._matrix[i, j] - matrix2._matrix[i, j];
                    rezult._matrix[i, j] = sum;
                }
            }
            return rezult;
        }
        
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix rezult = new Matrix(matrix1._rows, matrix1._columns);
            for (int i = 0; i < matrix1._rows; i++)
            {
                for (int j = 0; j < matrix1._columns; j++)
                {
                    int sum = matrix1._matrix[i, j] * matrix2._matrix[j, i];
                    rezult._matrix[i, j] = sum;
                }
            }
            return rezult;
        }

        public void ToString()
       {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
       }
    }
}
