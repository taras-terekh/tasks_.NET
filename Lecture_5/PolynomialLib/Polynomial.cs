using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialLib
{
    public class Polynomial
    {
        private int _degreeOfPolynomial;

        private int[] _array;

        public Polynomial(int degreeOfPolynomial)
        {
            this._degreeOfPolynomial = degreeOfPolynomial;
            _array = new int[_degreeOfPolynomial + 1];
        }

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            Polynomial rezult = new Polynomial(polynomial1._array.Length);
            for (int i = polynomial1._degreeOfPolynomial; i >= 0; i--)
            {
                int sum = polynomial1._array[i] + polynomial2._array[i];
                rezult._array[i] = sum;
            }
            return rezult;
        }

        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            Polynomial rezult = new Polynomial(polynomial1._array.Length);
            for (int i = polynomial1._degreeOfPolynomial; i >= 0; i--)
            {
                int sum = polynomial1._array[i] - polynomial2._array[i];
                rezult._array[i] = sum;
            }
            return rezult;
        }

        public void ToString()
        {
            for (int i = _degreeOfPolynomial - 1; i >= 0; i--)
            {
                if (i == 1)
                    Console.Write("{0}x + ", _array[i]);
                else if (i > 0)
                    Console.Write("{0}x^{1} + ", _array[i], i);
                else
                    Console.WriteLine("{0} ", _array[i]);
            }
        }
    }
}
