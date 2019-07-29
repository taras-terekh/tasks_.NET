using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolynomialLib;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreeOfPolynomial1 = 4;
            int degreeOfPolynomial2 = 5;
            int degreeOfPolynomial = 0;
            int select = 1;//Addition=1 Subtraction=2

            if (degreeOfPolynomial1 > degreeOfPolynomial2)
                degreeOfPolynomial = degreeOfPolynomial1;
            else if (degreeOfPolynomial1 < degreeOfPolynomial2)
                degreeOfPolynomial = degreeOfPolynomial2;

            Polynomial polynomial1 = new Polynomial(degreeOfPolynomial);
            Polynomial polynomial2 = new Polynomial(degreeOfPolynomial);
            Polynomial polynomial3 = new Polynomial(degreeOfPolynomial);
            Random rand = new Random();
            for (int i = degreeOfPolynomial1; i >= 0; i --)
            {
                polynomial1[i] = rand.Next(0, 100);
            }

            for (int i = degreeOfPolynomial2; i >= 0; i--)
            {
                polynomial2[i] = rand.Next(0, 100);
            }

            switch (select)
            {
                case 1:
                    polynomial3 = polynomial1 + polynomial2;
                    polynomial3.ToString();
                    break;
                case 2:
                    polynomial3 = polynomial1 - polynomial2;
                    polynomial3.ToString();
                    break;
            }
        }
    }
}
