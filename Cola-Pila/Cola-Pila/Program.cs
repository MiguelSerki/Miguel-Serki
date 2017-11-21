using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cola_Pila.Queue;
using Cola_Pila.Stack;

namespace Cola_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola<int> cola = new Cola<int>();
            Console.WriteLine("La cola tiene {0} elementos", cola.Cantidad());
            cola.Agregar(5);
            cola.Agregar(8);
            cola.Agregar(27);
            while (cola.Cantidad() != 0)
            {
                Console.WriteLine(cola.Tomar());
            }

            Pila<string> pila = new Pila<string>();
            Console.WriteLine("La pila tiene {0} elementos", pila.Cantidad());
            pila.Agregar("Ni le des de comer");
            pila.Agregar("No lo mojes...");
            pila.Agregar("La vida tiene 2 reglas:");

            while (pila.Cantidad() != 0)
            {
                Console.WriteLine(pila.Tomar());
            }
            Console.ReadLine();
        }
    }
}
