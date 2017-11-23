using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Empleados;

namespace TPOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Vendedor
            {
                Nombre = "Miguel",
                Apellido = "Serki",
                Dni = 36765467,
                Ingreso = 1999,
                HorasTrabajadas = 80,
                PrecioHora = 63,
                SueldoBase = 2000
            };

            var z = new Supervisor
            {
                Nombre = "Miguel",
                Apellido = "Serki",
                Dni = 36765467,
                Ingreso = 1999,
                HorasTrabajadas = 80,
                PrecioHora = 63,
                SueldoBase = 4000,
                Categoria = "c"
            };

            Console.WriteLine(z.CalcularHorasTrabajadas());
            Console.WriteLine(z.CalcularComision());
            Console.WriteLine(z.CalcularAntiguedad());
            Console.WriteLine(z.CalcularSueldo());

            Console.ReadLine();
        }
    }
}
