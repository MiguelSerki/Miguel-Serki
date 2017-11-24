using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class EmpleadoBuilder : IEmpleadoBuilder
    {
        private IEmpleados Empleado;
        public EmpleadoBuilder(IEmpleados empleado)
        {
            this.Empleado = empleado;
        }

        public void SetApellido()
        {
           Console.WriteLine("Apellido:");
           this.Empleado.Apellido = Console.ReadLine();
        }

        public void SetDni()
        {
            Console.WriteLine("Dni: ");
            this.Empleado.Dni = Console.ReadLine();
        }

        public void SetHorastrabajadas()
        {
            Console.WriteLine("Horas trabajadas");
            this.Empleado.HorasTrabajadas = (int)CheckNumber();
        }

        public void SetIngreso()
        {
            Console.WriteLine("Año de ingreso");
            this.Empleado.Ingreso = (int)CheckNumber();
        }

        public void SetNombre()
        {
            Console.WriteLine("Nombre:");
            this.Empleado.Nombre = Console.ReadLine();
        }

        public void SetPrecioHora()
        {
            Console.WriteLine("Precio por hora trabajada");
            this.Empleado.PrecioHora = CheckNumber();
        }

        public void SetSueldoBase()
        {
            if (this.Empleado is Vendedor)
                this.Empleado.Ingreso = 2000;
            this.Empleado.Ingreso = 4000;
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

        public IEmpleados GetEmpleado()
        {
            return this.Empleado;
        }
    }
}
