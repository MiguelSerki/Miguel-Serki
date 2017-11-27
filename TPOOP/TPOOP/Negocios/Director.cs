using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class Director <T> where T : IEmpleados
    {
        private EmpleadoBuilder<T> EmpleadoBuilder;
        private SupervisorBuilder<ISupervisor> SupervisorBuilder;
        private ListaEmpleados Lista;

        public Director(EmpleadoBuilder<T> builder, SupervisorBuilder<ISupervisor> supervisor)
        {
            this.EmpleadoBuilder = builder;
            this.SupervisorBuilder = supervisor;
            this.Lista = new ListaEmpleados();
        }

        public void ConstructEmpleado(T empleado, string key)
        {

            if (key.ToLower() == "v")
            {
                this.EmpleadoBuilder.SetNombre(empleado);
                this.EmpleadoBuilder.SetApellido(empleado);
                this.EmpleadoBuilder.SetDni(empleado);
                this.EmpleadoBuilder.SetIngreso(empleado);
                this.EmpleadoBuilder.SetPrecioHora(empleado);
                this.EmpleadoBuilder.SetHorastrabajadas(empleado);
                this.EmpleadoBuilder.SetSueldoBase(empleado);
                this.Lista.GetLista().Add(empleado);
            }
            else
            {
                this.SupervisorBuilder.SetNombre((ISupervisor)empleado);
                this.SupervisorBuilder.SetApellido((ISupervisor)empleado);
                this.SupervisorBuilder.SetDni((ISupervisor)empleado);
                this.SupervisorBuilder.SetIngreso((ISupervisor)empleado);
                this.SupervisorBuilder.SetPrecioHora((ISupervisor)empleado);
                this.SupervisorBuilder.SetHorastrabajadas((ISupervisor)empleado);
                this.SupervisorBuilder.SetSueldoBase((ISupervisor)empleado);
                this.SupervisorBuilder.SetCategoria((ISupervisor)empleado);
                this.Lista.AddToLista(empleado);
            }

        }

        public List<IEmpleados> ListEmpleados()
        {
            return this.Lista.GetLista();
        }

        public List<IEmpleados> MejoresPago()
        {
            IEmpleados x;
            IEmpleados y;
            List<IEmpleados> z = new List<IEmpleados>();
            try
            {
                x = this.Lista.GetLista().Where(e => e is Vendedor)
                              .OrderByDescending(e => e.CalcularSueldo())
                              .First();
                z.Add(x);
            }
            catch (Exception)
            {
                Console.WriteLine("No se encontraron vendedores");
            }
            try
            {
                y = this.Lista.GetLista().Where(e => e is Supervisor)
                              .OrderByDescending(e => e.CalcularSueldo())
                              .First();
                z.Add(y);

            }
            catch (Exception)
            {
                Console.WriteLine("No se encontraron supervisores");
            }
            return z;
        }
    }
}
