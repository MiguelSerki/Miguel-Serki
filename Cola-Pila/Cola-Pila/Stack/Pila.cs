using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Pila.Stack
{
    class Pila <T>
    {
        private LinkedList<T> lista;

        public Pila()
        {
            this.lista = new LinkedList<T>();
        }

        public void Agregar(T x)
        {
            if (this.Cantidad() == 0)
            {
                this.lista.AddFirst(x);
            }
            else
            {
                this.lista.AddLast(x);
            }

        }
        public T Tomar()
        {

            if (this.Cantidad() == 0)
            {
                Console.WriteLine("La pila esta vacia");
                return default(T);
            }
            else
            {
                T x = this.lista.Last();
                this.lista.RemoveLast();
                return x;
            }
        }
        public int Cantidad()
        {
            return this.lista.Count;
        }

    }
}
