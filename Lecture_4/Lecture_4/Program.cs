﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square data = new Square();
            data.side = 5;
            data.CalculateSquare(data.side);
        }
    }
}
