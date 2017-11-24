using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class Director
    {
        private EmpleadoBuilder Builder;

        public Director(EmpleadoBuilder builder)
        {
            this.Builder = builder;
        }

        public void ConstructEmpleado()
        {
            this.Builder.SetNombre();
            this.Builder.SetApellido();
            this.Builder.SetDni();
            this.Builder.SetIngreso();
            this.Builder.SetPrecioHora();
            this.Builder.SetHorastrabajadas();
            this.Builder.SetSueldoBase();
        }

        public IEmpleados GetEmpleados()
        {
            return this.Builder.GetEmpleado();
        }
    }
}
