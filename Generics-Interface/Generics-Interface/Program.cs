using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics_Interface.Ejercicio27;
using Generics_Interface.Ejercicio25;
using Generics_Interface.Ejercicio24;
using Generics_Interface.Ejercicio23;
using Generics_Interface.Ejercicio30;
using Generics_Interface.Ejercicio31;
using Generics_Interface.Ejercicio29;

namespace Generics_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ej 23
            var ej = new E23<int>();
            int x = 564;
            Console.WriteLine(ej.Retornar(x));
            Console.ReadLine();
            ej24
            var ej = new Ejercicio24<string>();
            var ej2 = new Ejercicio24<int>();
            var x = 200;
            var y = "No lo mojes";
            ej.WriteGen(y);
            ej2.WriteGen(x);
            Console.ReadLine();
            
            ej25
            var ej = new E25<string>();
            var ej2 = new E25<int>();
            var x = 25;
            var y = 25;
            var z = 40;
            var a = "a";
            var b = "b";
            var c = "a";
            Console.WriteLine(ej.Comparar(a, b));
            Console.WriteLine(ej.Comparar(a, c));
            Console.WriteLine(ej2.Comparar(x, y));
            Console.WriteLine(ej2.Comparar(x, z));
          
            ej27
            var ej27 = new E27<int>();

            var x = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            var y = new List<int>
            {   9,
                8,
                7,
                6,
                5
            };

            Console.WriteLine(ej27.Interseccion(x, y));
            Ej 30
            var x = new Perro { Nombre = "Fido"};
            var y = new Gato { Nombre = "mauri" };
            var z = new Pajaro { Nombre = "No se" };
            x.Saludar();
            y.Saludar();
            z.Saludar();
            */

            var avion = new Avion();
            var auto = new Auto();
            avion.Acelerar();
            avion.Despegar();
            avion.Aterrizar();

            auto.Acelerar();
            auto.Girar();
            auto.Frenar();

            var cont = new ClaseContenedor();
            cont.Agregar();
            cont.EstaRepetido();

            Console.ReadLine();

        }
    }
}
