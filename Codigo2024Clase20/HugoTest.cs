﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo2024Clase20
{
    public class HugoTest
    {
        public int Sumar(int a,int b)
        {
            return a + b;
        }
        public int Restar(int a, int b)
        {
            if (a < b)
                return 0;
            else
                return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}
