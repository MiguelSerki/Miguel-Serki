using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Interface.Ejercicio24
{

    public class Ejercicio24 <T>
    {
        public void WriteGen(T item)
        {
            Console.WriteLine(item);
        }
    }
}
