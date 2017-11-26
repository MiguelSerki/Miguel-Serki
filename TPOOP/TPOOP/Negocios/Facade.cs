using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class Facade
    {
        private Director<IEmpleados> Director;
        private EmpleadoBuilder<IEmpleados> Builder;

        public Facade()
        {
            this.Builder = new EmpleadoBuilder<IEmpleados>();
            this.Director = new Director<IEmpleados>(this.Builder);
        }

        public void OptionA(string dato)
        {
                try
                {
                    var empleado = this.Director.ListEmpleados().Where(e => e.Dni == dato).Single();
                Console.WriteLine($"Nombre: {empleado.Nombre}. Apellido: {empleado.Apellido}. DNI: {empleado.Dni}. Sueldo: ${empleado.CalcularSueldo()}.");
            }
                catch (Exception)
                {
                    Console.WriteLine("No existe el empleado requerido");
                }
        }
        public void OptionB(string dato)
        {
            try
            {
                var empleado = this.Director.ListEmpleados().Where(e => e.Dni == dato).Single();
                this.Director.ListEmpleados().Remove(empleado);
            }
            catch (Exception)
            {
                Console.WriteLine("No existe el empleado requerido");
            }
        }
        public void OptionC(string dato)
        {
            this.Director.ConstructEmpleado(EmpleadosFactory.GetEmpleado(dato));
        }
        public void OptionL()
        {
            try
            {
                foreach (var empleado in this.Director.MejoresPago())
                {
                    Console.WriteLine($"Nombre: {empleado.Nombre}. Apellido: {empleado.Apellido}. DNI: {empleado.Dni}. Sueldo: ${empleado.CalcularSueldo()}.");
                }
            }
            catch (Exception)
            {
            } 
            
        }
    }
}
