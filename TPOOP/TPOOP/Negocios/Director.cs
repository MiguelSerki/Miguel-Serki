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
        private EmpleadoBuilder<T> Builder;
        private ListaEmpleados Lista;

        public Director(EmpleadoBuilder<T> builder)
        {
            this.Builder = builder;
            this.Lista = new ListaEmpleados();
        }

        public void ConstructEmpleado(T empleado)
        {
            this.Builder.SetEmpleado(empleado);
            this.Builder.SetNombre();
            this.Builder.SetApellido();
            this.Builder.SetDni();
            this.Builder.SetIngreso();
            this.Builder.SetPrecioHora();
            this.Builder.SetHorastrabajadas();
            this.Builder.SetSueldoBase();
            this.Lista.AddEmpleado(empleado);
        }

        public T GetEmpleados()
        {
            return this.Builder.GetEmpleado();
        }

        public List<IEmpleados> ListEmpleados()
        {
            return this.Lista.GetLista();
        }

        public List<IEmpleados> MejoresPago()
        {
            IEmpleados x;
            IEmpleados y;
            List<IEmpleados> z = null;
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
