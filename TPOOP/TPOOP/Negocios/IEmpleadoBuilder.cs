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
        void SetNombre(T Empleado);
        void SetApellido(T Empleado);
        void SetIngreso(T Empleado);
        void SetDni(T Empleado);
        void SetPrecioHora(T Empleado);
        void SetHorastrabajadas(T Empleado);
        void SetSueldoBase(T Empleado);
    }
}
