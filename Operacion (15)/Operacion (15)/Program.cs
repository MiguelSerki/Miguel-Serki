using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion__15_
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma()
            {
                valor1 = 5,
                valor2 = 7
            };
            Console.WriteLine("{0} + {1} = {2}", suma.valor1, suma.valor2, suma.Operar());
            Console.ReadLine();
        }
    }
}
