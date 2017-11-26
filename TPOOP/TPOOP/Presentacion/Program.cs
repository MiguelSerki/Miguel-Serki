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
            var Facade = new Facade();
            string key;
            do
            {
                Console.WriteLine("Ingrese un comando:");
                Console.WriteLine("A: Buscar empleado por DNI y calcular su sueldo. B: Buscar empleado por DNI y borrarlo. C: Crear un nuevo empleado. L: Listar todos los empleados con mayor sueldo. E: Salir del programa");
                key = Console.ReadLine();
                switch (key.ToLower())
                {
                    case "a":
                        Console.WriteLine("Ingrese un Dni:");
                        var dni = Console.ReadLine();
                        Facade.OptionA(dni);
                        break;
                    case "b":
                        Console.WriteLine("Ingrese un Dni:");
                        var dni2 = Console.ReadLine();
                        Facade.OptionB(dni2);
                        break;
                    case "c":
                        Console.WriteLine("Ingrese V para crear un vendedor, S para crear un supervisor, o cualquier otra cosa para volver atras");
                        var x = Console.ReadLine();
                        if (x.ToLower() == "v" || x.ToLower() == "s")
                            Facade.OptionC(x);
                        break;
                    case "l":
                        Facade.OptionL();
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
