using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 8) ingresar 10 numeros, sumar los + y multiplicar los -.
 * 9) Ingresar dos numeros e intercambiarlos, es decis mostrar los valores intercambiados.
 * 10) Ingresar un numero y mostrar su cuadrado y su cubo.
 * 11) ingresar x cantidad de pesos y mostrar la cantidad de personas que pesan + de 80 y - de 80
 * 12) ingresar 3 datos y decir que clase de triangulo es. Para formar un triangulo hay que tener en cuenta que la suma de sus
 * dos lados inferiores tiene que ser mayor a el lado superior.
 * 
 * 14)Realizar la tabla de multiplicar de un numero ingresado entre 0 y 10
 * de forma que se visualice de la siguiente forma:
 * 4x1 = 4, 4x2 =8
 * 15)Ingresar 2 numeros, imprima los numeros naturales que hay entre ambos, empezando por el mas pequeño, 
 * contar cuantos numeros hay,
 * y cuantos de ellos son pares
 */
namespace Listas
{
    class Program
    {
        private static List<int> lista = new List<int>();

        static void Main(string[] args)
        {
            /*SetList();
            Impares(lista);
            Pares(lista);
            MultiplosDe3(lista);
            MultiploDe2Y3(lista);
            List<int> lista2 = new List<int>();
            IngresarNum(lista2);
            MostrarDesde1();
            ContarMultiplos();*/
            //            ej8();
            // ej9();
            //  ej10();
            // ej11();
            //ej13();
            //ej14();
            ej15();

            Console.ReadLine();

        }

        public static void SetList()
        {
            for (int i = 0; i <= 100; i++)
            {
                lista.Add(i);
            }
        }
        public static void ej8()
        {
            List<int> lista = new List<int>(0);
            int i = 0;
            int pos = 0;
            int neg = 1;
            string ingresar;
            for (int a = 0; a < 10; a++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    ingresar = Console.ReadLine();
                } while (!(int.TryParse(ingresar, out i)));
                lista.Add(i);
            }
            foreach(int n in lista)
            {
                if (n >= 0)
                {
                    pos += n;
                }
                else
                {
                    neg *= n;
                }
            }
            Console.WriteLine("Los positivos suman {0}, los negativos se multiplican a {1}", pos, neg);

        }
        public static void ej9()
        {
            int i = 0;
            int x = 0;
            int y = 0;
            string ingresar;
            do
                {
                    Console.WriteLine("Ingrese un numero");
                    ingresar = Console.ReadLine();
                } while (!(int.TryParse(ingresar, out x)));
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out y)));

            i = x;
            x = y;
            y = i;
            Console.WriteLine("El primero (x) es {0}, y el segundo (y) es {1}", x, y); 
        }
        public static void ej10()
        {

            int i = 0;
            int cubo;
            int cuadrado;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));
            cuadrado = i * i;
            cubo = cuadrado * i;
            Console.WriteLine("El cuadrado de {0} es: {1}. Y su cubo es {2}", i, cuadrado, cubo);
        }
        public static void ej11(){

            Console.WriteLine("Ingrese x cantidad de pesos, hasta que ingrese 0");
            List<int> lista = new List<int>(0);
            int i = 0;
            int menor80 = 0;
            int mayor80 = 0;
            string ingresar;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    ingresar = Console.ReadLine();
                } while (!(int.TryParse(ingresar, out i)));
                lista.Add(i);
            } while (i != 0);
            lista.Remove(0);
            foreach(int n in lista)
            {
                if (n < 80)
                {
                    menor80++;
                }
                else
                {
                    mayor80++;
                }
            }
            Console.WriteLine("Hay {0} personas que pesan menos de 80 y {1} que pesan 80 o más", menor80, mayor80);
            Console.WriteLine();
        }
        public static void ej12()
        {
            List<int> lista = new List<int>();
            int x = 0;
            int y = 0;
            int z = 0;
            int mayor = 0;
            int[] menores = new int[2];

            string ingresar;
            Console.WriteLine("Ingrese 3 numeros para ver que tipo de triangulo es");
 
            do
                {
                    Console.WriteLine("Ingrese el primer lado");
                    ingresar = Console.ReadLine();
                } while (!(int.TryParse(ingresar, out x)));
            do
            {
                Console.WriteLine("Ingrese el segundo lado");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out y)));
            do
            {
                Console.WriteLine("Ingrese el tercer lado");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out z)));
        if (x == y && y == z)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else
            {
                if (x < y)
                {

                }
            }
          
        }
        public static void ej13()
        {
            int x = 0;
            int y = 0;
            int z = 0;
            string ingresar;
            bool existe = false;
            Console.WriteLine("Ingrese 2 numeros para ver si el 3ro es parte del intervalo entre el primero y el segundo");

            do
            {
                Console.WriteLine("Ingrese el primer intervalo");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out x)));
            do
            {
                Console.WriteLine("Ingrese el segundo intervalo");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out y)));
            do
            {
                Console.WriteLine("Ingrese el tercer numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out z)));
            
            if (x == y)
            {
                Console.WriteLine("Los primeros numeros son iguales, no hay intervalo");
            }
            else
            {
                if (x < y)
                {
                    for (int i = x; i<y; i++)
                    {
                        if (i == z)
                        {
                            existe = true;
                        }
                    }
                }
                else
                {
                    for (int i = y; i < x; i++)
                    {
                        if (i == z)
                        {
                            existe = true;
                        }
                    }
                }
            }

            if (existe)
            {
                Console.WriteLine("Si existe");
            }
            else
            {
                Console.WriteLine("No existe");
            }
        }
        public static void ej14()
        {
            Console.WriteLine("Ingrese un numero para darte la tablita de 1 a 10");
            int x = 0;
            int mult = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out x)));
            for(int i =1; i<=10; i++)
            {
                mult = i * x;
                Console.WriteLine("{0} x {1} = {2}", x, i, mult);
            }
        }
        public static void ej15()
        {

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


        public static void Impares(List<int> lista)
        {
            Console.WriteLine("Impares del 1 al 100");
            foreach (int i in lista){
                if(!(i%2 == 0))
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void Pares(List<int> lista)
        {
            Console.WriteLine("Pares del 1 al 100");
            foreach (int i in lista)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
        public static void MultiplosDe3(List<int> lista)
        {
            Console.WriteLine("Multiplos de 3 del 0 al 100");
            foreach(int n in lista)
            {
                if (n%3 == 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
        public static void MultiploDe2Y3(List<int> lista)
        {
            Console.WriteLine("Multiplos de 2 y 3 del 0 al 100");
            foreach (int n in lista)
            {
                if (n%2 == 0 || n%3 == 0)
                {
                    Console.Write(n+" ");
                }
            }
            Console.WriteLine();
        }
        public static void IngresarNum(List<int> lista)
        {
            Console.WriteLine("Ingresar un numero y te mostramos la suma de los anteriores");
            int i = 0;
            int final = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));

            for (int a = 0; a<=i; a++)
            {
                lista.Add(a);
            }
            foreach (int n in lista)
            {
                final += n;
            }
            Console.WriteLine(final);
            Console.WriteLine();
        }
        public static void MostrarDesde1()
        {
            Console.WriteLine("Ingresar un numero y te mostramos desde el 1 hasta ese numero");
            int i = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));
            for (int a = 1; a<=i; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        public static void ContarMultiplos()
        {
            Console.WriteLine("Multiplos de 3 desde el numero ingresado");
            int i = 0;
            int count = 0;
            string ingresar;
            do
            {
                Console.WriteLine("Ingrese un numero");
                ingresar = Console.ReadLine();
            } while (!(int.TryParse(ingresar, out i)));
            for (int a = 1; a<= i; a++)
            {
                if (a%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Hay {0} numeros multiplo de 3 desde el numero ingresado",count);
            Console.WriteLine();
        }
    }
}
