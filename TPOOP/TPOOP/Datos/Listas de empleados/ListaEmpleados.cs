using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public class ListaEmpleados : IListaEmpleados
    {
        private List<IEmpleados> Lista { get; set; }
        public IEmpleados GetEmpleado(string Dni)
        {
            try
            {
              var x = Lista.Where(e => e.Dni == Dni).Single();
              return x;
            }
            catch (Exception)
            {
                Console.WriteLine("No existe el empleado requerido");
                return null;
            }
        }
        public IEmpleados MejoresPago()
        {
            IEmpleados x;
            try
            {
             x = Lista.OrderByDescending(e => e.CalcularSueldo()).First();
            }
            catch (Exception)
            {
                Console.WriteLine("La lista de empleados esta vacia");
                return null;
            }
            return x;
        }
    }
}
