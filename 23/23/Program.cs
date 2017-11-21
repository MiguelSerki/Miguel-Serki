using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        public T Maximo<T>(T x, T y) where T : IComparable
        {
            if (x.CompareTo(y) > 1)
                return x;
            return y;
        }
    }
}