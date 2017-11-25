using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Negocios;

namespace TPOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido/a al programa");
            var Builder = new EmpleadoBuilder();
            var Director = new Director(Builder);
            string key;
            do
            {
                Console.WriteLine("Ingrese un comando:");
                Console.WriteLine("A: buscar empleado por DNI y calcular su sueldo. B: Borrar un empleado. C: crear un nuevo empleado. L: Listar todos los empleados con mayor sueldo. E: Salir del programa");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "a":
                        break;
                    case "b":
                        break;
                    case "c":
                        Console.WriteLine("Ingrese V para crear un vendedor, S para crear un supervisor, o cualquier otra cosa para volver atras");
                        var x = Console.ReadLine();
                        if (x.ToLower() == "v" || x.ToLower() == "s")
                            Director.ConstructEmpleado(EmpleadosFactory.GetEmpleado(x));
                        break;
                    case "l":
                        break;
                    case "e":
                        Console.WriteLine("Saliendo, gracias vuelva prontos :)");
                        break;
                    default:
                        Console.WriteLine("Caracter invalido, intente de nuevo");
                        key = "defaultResponse";
                        break;
                }
            } while (key.ToLower() != "e" );

            Console.ReadLine();
        }
    }
}
