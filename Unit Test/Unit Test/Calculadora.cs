using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class Calculadora
    {
        public int Agregar(int v1, int v2)
        {
            return v1 + v2;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar (int a, int b)
        {
            return a * b;
        }

        public decimal Dividir (int a, int b)
        {
            return a / b;
        }
    }
}
