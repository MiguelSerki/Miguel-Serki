using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    interface IEmpleadoBuilder <T> where T :IEmpleados
    {
        void SetNombre();
        void SetApellido();
        void SetIngreso();
        void SetDni();
        void SetPrecioHora();
        void SetHorastrabajadas();
        void SetSueldoBase();
        void SetEmpleado(T empleado);
        T GetEmpleado();
    }
}
