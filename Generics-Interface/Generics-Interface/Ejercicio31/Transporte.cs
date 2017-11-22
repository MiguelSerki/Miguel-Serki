using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Interface.Ejercicio31
{
    public class Auto : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("El auto acelera");
        }

        public void Frenar()
        {
            Console.WriteLine("El auto frena");
        }

        public void Girar()
        {
            Console.WriteLine("El auto gira");
        }
    }

    public class Avion : Voladores
    {
        public void Acelerar()
        {
            Console.WriteLine("El avion acelera");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El avion aterriza");
        }

        public void Despegar()
        {
            Console.WriteLine("El avion despega");
        }

        public void Frenar()
        {
            Console.WriteLine("El avion frena");
        }

        public void Girar()
        {
            Console.WriteLine("El avion gira");
        }
    }
}
