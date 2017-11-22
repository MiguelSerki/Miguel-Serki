using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {

        /*
Generar los metodos 
EsFuerte() que devuelve un bool si la clave interna contiene al menos 1 numero y una mayuscula

Clave(bool generar) que devuelve la clave y toma un bool que indica si debe debe regenerar la clave con la longitud interna y luego devuelve la clave.

Crear una app de consola que permita el ingreso al usuario de una longitud para su generador de password y que el sistema le permita las siguientes operaciones
- Si ingresa 'e' indicar si su clave es fuerte o 'No tiene clave' si aun no la genero

- Si ingresa 'c' se debe preguntar si se desea generar nuevamente con 's' o 'n' ( Pedir dato hasta que sea correcto) y luego mostrar la clave

- Si ingresa 'f' - Finalizar el sistema

Pedir operaciones hasta que el usuario ingrese f.
*/
        static void Main(string[] args)
        {
            string command;
            Console.WriteLine("Bienvenide al programe");
            Console.WriteLine("Use estos comandos para navegar");
            Console.WriteLine("F para terminar, E para fuerza y C para generar contraseña");
            do
            {
                Console.WriteLine("Ingrese un comando");
                command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "e":
                        break;
                    case "c":
                        break;
                    default:
                        Console.WriteLine("Ingresaste un caracter no valido");
                        break;
                }
            } while (command != "f");
        }
    }
}
