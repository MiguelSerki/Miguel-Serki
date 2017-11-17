using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Console.WriteLine("Bienvenide al programe");
            Console.WriteLine("Ingrese commandos para navegar");
            Console.WriteLine("F para terminar, E para fuerza y C para contraseña");
            do
            {
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
