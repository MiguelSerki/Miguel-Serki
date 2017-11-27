using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class EmpleadoBuilder <T>: IEmpleadoBuilder <T> where T : IEmpleados
    {

        public void SetApellido(T Empleado)
        {
           Console.WriteLine("Apellido:");
           Empleado.Apellido = Console.ReadLine();
        }

        public void SetDni(T Empleado)
        {
            Console.WriteLine("Dni: ");
            Empleado.Dni = Console.ReadLine();
        }

        public void SetHorastrabajadas(T Empleado)
        {
            Console.WriteLine("Horas trabajadas");
            Empleado.HorasTrabajadas = (int)CheckNumber();
        }

        public void SetIngreso(T Empleado)
        {
            Console.WriteLine("Año de ingreso");
            Console.WriteLine("Debe ser un año valido");
            do
            {
              Empleado.Ingreso = (int)CheckNumber();
            } while (Empleado.Ingreso > DateTime.Now.Year);
        }

        public void SetNombre(T Empleado)
        {
            Console.WriteLine("Nombre:");
            Empleado.Nombre = Console.ReadLine();
        }

        public void SetPrecioHora(T Empleado)
        {
            Console.WriteLine("Precio por hora trabajada");
            Empleado.PrecioHora = CheckNumber();
        }

        public void SetSueldoBase(T Empleado)
        {
            if (Empleado is Vendedor)
                Empleado.Ingreso = 2000;
            Empleado.Ingreso = 4000;
        }

        private static decimal CheckNumber()
        {
            string x;
            decimal y;
            do
            {
                Console.WriteLine("Ingrese un valor valido: ");
                x = Console.ReadLine();
            } while (!decimal.TryParse(x, out y));
            return y;
        }
    }
}
