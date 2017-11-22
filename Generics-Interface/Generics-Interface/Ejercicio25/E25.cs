using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Interface.Ejercicio25
{
    public class E25
    {
        public bool Comparar<T>(T x, T y) where T : IComparable
        {
            return x.Equals(y);
                

        }
    }
}
