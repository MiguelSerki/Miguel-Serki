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
        private T Empleado;

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
            Console.WriteLine("Debe ser un año valido");
            while(this.Empleado.Ingreso > DateTime.Now.Year)
            {
            this.Empleado.Ingreso = (int)CheckNumber();
            } 
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

        public void SetEmpleado(T empleado)
        {
            this.Empleado = empleado;
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

        public T GetEmpleado()
        {
            return this.Empleado;
        }
    }
}
