using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public class ListaEmpleados
    {
        private List<IEmpleados> Lista { get; set; } = new List<IEmpleados>();

        public IEmpleados GetEmpleado(string Dni)
        {
            try
            {
              var x = this.Lista.Where(e => e.Dni == Dni).Single();
              return x;
            }
            catch (Exception)
            {
                Console.WriteLine("No existe el empleado requerido");
                return null;
            }
        }
        public  List<IEmpleados> MejoresPago(List<IEmpleados> lista)
        {
            IEmpleados x;
            IEmpleados y;
            List<IEmpleados> z = null;
            try
            {
                x = this.Lista.Where(e=> e is Vendedor)
                              .OrderByDescending(e => e.CalcularSueldo())
                              .First();
            }
            catch (Exception)
            {
                Console.WriteLine("La lista de empleados esta vacia");
                x = null;
            }
            try
            {
                y = this.Lista.Where(e => e is Supervisor)
                              .OrderByDescending(e => e.CalcularSueldo())
                              .First();

            }
            catch (Exception)
            {
                Console.WriteLine("La lista de empleados esta vacia");
                y = null;
            }
            z.Add(x);
            z.Add(y);
            return z;
        }
        public void AddEmpleado(IEmpleados empleado)
        {
            this.Lista.Add(empleado);
        }
        public void RemoveEmpleado (IEmpleados empleado)
        {
            this.Lista.Remove(empleado);
        }
    }
}
