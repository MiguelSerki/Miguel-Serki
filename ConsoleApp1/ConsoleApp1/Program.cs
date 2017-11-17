using ClassLibrary3;
using ConsoleApp1.Foo;
using System;
namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            int x= 0;
            int y = 0;
            int z = 0;
            int w =  0;
            int last = 0;
            Func<int, int, int> operacion = Resta;
            Func<int, int, int> operacion2 = Suma;
            Setter(ref x);
            Setter(ref y);
            if (Op(x, y, ref z))
            {
                Setter(ref w);
                Op(z, w, ref last);
            }
       
            Console.ReadLine();

        }
        private static void Setter (ref int x)
        {
            string input;
            do
            {
                Console.WriteLine("Ingrese un numero");
                input = Console.ReadLine();
            }
            while (!(int.TryParse(input, out int int3)));
        x = int.Parse(input);

        }
        private static bool Op(int x, int y, ref int z)
        {
            string value;
            bool control = true;
            Console.WriteLine("Ingrese S para sumar, R para restar, M para multiplicar, o D para dividir");
            value = Console.ReadLine();
            switch (value.ToLower())
            {
                case "s":
                    z = Suma(x, y);
                    Console.WriteLine("Tu resultado fue {0}", z);
                    break;
                case "r":
                    z = Resta(x, y);
                    Console.WriteLine("Tu resultado fue {0}", z);
                    break;
                case "m":
                    z = Multi(x, y);
                    Console.WriteLine("Tu resultado fue {0}", z);
                    break;
                case "d":
                    if (x == 0 || y == 0)
                    {
                        Console.WriteLine("Estas dividiendo por 0! Blasfemia!");
                        control = false;
                    }
                    else
                    {
                        z = Divi(x, y);
                        Console.WriteLine("Tu resultado fue {0}", z);
                    }
                    break;
                default:
                    Console.WriteLine("Has ingresado un caracter no valido");
                    control = false;
                    break;
            }


            return control;
        }
        private static int Suma(int x, int y)
        {
            return x + y;
        }
        private static int Resta(int x, int y)
        {
            return x - y;
        }
        private static int Multi(int x, int y)
        {
            return x * y;
        }
        private static int Divi (int x, int y)
        {
            return x / y;
        }

    }
}