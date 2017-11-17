using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2
{
    class Program
    {
        /*
         * 13.	 Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. 
         * También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.
         14.Escribir una clase Persona definirle los atributos nombre y edad. 
         Definir un método en el cual muestre el nombre de la persona y si es mayor de edad.*/

        static void Main(string[] args)
        {
            //ej1();
            //ej2();
            //ej3();
            //ej5();
            // ej6();
            ej11();

            Console.ReadLine();
        }

        public static void ej1()
        {
            Console.WriteLine("Ingrese tres numeros para devolver la suma de los 3");
            int x = 0;
            GetNumber(ref x);
            int i = 0;
            GetNumber(ref i);
            int z = 0;
            GetNumber(ref z);
            int w = x + i + z;
            Console.WriteLine("La suma de {0}, {1}, y {2} es = {3}", x, i, z, w);



        }
        public static void ej2()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese una ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Hola {0}, bienvenide a {1}", nombre, ciudad);
        }
        public static void ej3()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            string edad = Console.ReadLine();
            Console.WriteLine("Te llamas {0} y tenes {1} años", nombre, edad);
        }
        public static void ej5()
        {
            Console.WriteLine("Ingrese un dia y le diremos si es o no fin de semana");
            string dia = Console.ReadLine();

            switch (dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine("No es finde :(");
                    break;
                case "martes":
                    Console.WriteLine("No es finde :(");
                    break;
                case "miercoles":
                    Console.WriteLine("No es finde :(");
                    break;
                case "jueves":
                    Console.WriteLine("No es finde :(");
                    break;
                case "viernes":
                    Console.WriteLine("No es finde, pero esta ahi!");
                    break;
                case "sabado":
                    Console.WriteLine("Ya es finde yay!");
                    break;
                case "domingo":
                    Console.WriteLine("Ya es finde, pero mañana es lunes :(");
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }
        }
        public static void ej6()
        {
            Console.WriteLine("Ingrese el precio de un producto (solo positivo)");
            int x = 0;
            do
            {
                GetNumber(ref x);
            } while (x < 0);

            Console.WriteLine("Ingrese su medio de pago: tarjeta, efectivo, fiado");
            string pago = Console.ReadLine();
            if (pago != "tarjeta" && pago != "efectivo" && pago != "fiado")
            {
                Console.WriteLine("No elejiste un medio de pago legal. Transaccion cancelada");
            }
            else if (pago == "tarjeta")
            {
                Console.WriteLine("Ingrese su numero de cuenta");
                int y = 0;
                GetNumber(ref y);
                Console.WriteLine("El precio de tu producto es: {0} y elejiste {1} para pagar", x, pago);
            }
            else
            {
                Console.WriteLine("El precio de tu producto es: {0} y elejiste {1} para pagar", x, pago);
            }

        }
        public static void ej11()
        {
            Console.WriteLine("Ingrese su pedido, primero lo que desea ordenar y luego la cantidad. Presione t para terminar");
            bool pedido = true;
            List<Item> lista = new List<Item>();
            do
            {
                Item x = new Item();
                Console.WriteLine("Ingrese su orden");
                x.detalle = Console.ReadLine();
                if (x.detalle == "t")
                {
                    pedido = false;
                }
                else
                {
                    int z = 0;
                    GetNumber(ref z);
                    x.cantidad = z;
                    lista.Add(x);
                }
            } while (pedido);
            Console.WriteLine("Usted pidio:");
            foreach (Item n in lista)
            {
                Console.WriteLine("{0} {1}",n.cantidad, n.detalle);
            }
        }

        public static void GetNumber(ref int numero)
        {
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out numero)));
        }
    }
}
