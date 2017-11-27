using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public class ListaEmpleados
    {
        private List<IEmpleados> Lista = new List<IEmpleados>();

        public void AddToLista( IEmpleados empleado)
        {
            this.Lista.Add(empleado);
        }

        public List<IEmpleados> GetLista()
        {
            return this.Lista;
        }
    }
}
